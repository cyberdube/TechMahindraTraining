import { Component, OnInit } from '@angular/core';
import { Contact } from '../contact.model';
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {
  contacts: Contact[] = [];
  selectedContact: Contact | null = null;

  constructor(private contactService: ContactService) { }

  ngOnInit(): void {
    this.loadContacts();
  }

  loadContacts() {
    this.contacts = this.contactService.getContacts();
  }

  editContact(contact: Contact) {
    this.selectedContact = { ...contact };
  }

  deleteContact(contactId: number) {
    this.contactService.deleteContact(contactId);
    this.loadContacts();
  }

  onContactSaved() {
    this.loadContacts();
    this.selectedContact = null;
  }
}
