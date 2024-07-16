import { Component, OnInit } from '@angular/core';
import { BookService } from '../book.service';
import { Book } from '../book.model';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {
  books: Book[] = [];
  searchQuery = '';

  constructor(private bookService: BookService) { }

  ngOnInit(): void {
    this.bookService.getAllBooks().subscribe(books => {
      this.books = books;
    });
  }

  deleteBook(id: number): void {
    this.bookService.deleteBookById(id).subscribe(() => {
      this.books = this.books.filter(book => book.id !== id);
    });
  }

  filteredBooks(): Book[] {
    return this.books.filter(book => 
      book.title.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
      book.author.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
      book.genre.toLowerCase().includes(this.searchQuery.toLowerCase())
    );
  }
}
