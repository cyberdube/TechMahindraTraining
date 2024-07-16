import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from '../book.service';
import { Book } from '../book.model';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  book: Book = { id: 0, title: '', author: '', genre: '', description: '', publishedDate: new Date(), readStatus: false };

  constructor(private bookService: BookService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    const idParam = this.route.snapshot.paramMap.get('id');
    const id = idParam ? +idParam : null;
    if (id !== null) {
      this.bookService.getBookById(id).subscribe(book => {
        this.book = book;
      });
    }
  }

  saveBook(): void {
    if (this.book.id) {
      this.bookService.updateBook(this.book).subscribe(() => {
        this.router.navigate(['/show']);
      });
    } else {
      this.bookService.createBook(this.book).subscribe(() => {
        this.router.navigate(['/show']);
      });
    }
  }
}
