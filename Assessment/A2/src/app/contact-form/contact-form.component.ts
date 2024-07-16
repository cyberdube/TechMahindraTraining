import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Contact } from '../contact.model';
import { ContactService } from '../contact.service';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.css']
})
export class ContactFormComponent {
  @Input() contact: Contact = { id: 0, name: '', phone: '', email: '' };
  @Output() contactSaved = new EventEmitter<void>();

  constructor(private contactService: ContactService) { }

  saveContact() {
    if (this.contact.id) {
      this.contactService.updateContact(this.contact);
    } else {
      this.contactService.addContact(this.contact);
    }
    this.contactSaved.emit();
    this.resetForm();
  }

  resetForm() {
    this.contact = { id: 0, name: '', phone: '', email: '' };
  }
}
