import { Injectable } from '@angular/core';
import { Contact } from './contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private storageKey = 'contacts';

  constructor() { }

  getContacts(): Contact[] {
    const contacts = localStorage.getItem(this.storageKey);
    return contacts ? JSON.parse(contacts) : [];
  }

  saveContacts(contacts: Contact[]): void {
    localStorage.setItem(this.storageKey, JSON.stringify(contacts));
  }

  addContact(contact: Contact): void {
    const contacts = this.getContacts();
    contact.id = new Date().getTime();
    contacts.push(contact);
    this.saveContacts(contacts);
  }

  updateContact(updatedContact: Contact): void {
    const contacts = this.getContacts();
    const index = contacts.findIndex(contact => contact.id === updatedContact.id);
    if (index > -1) {
      contacts[index] = updatedContact;
      this.saveContacts(contacts);
    }
  }

  deleteContact(contactId: number): void {
    let contacts = this.getContacts();
    contacts = contacts.filter(contact => contact.id !== contactId);
    this.saveContacts(contacts);
  }
}
