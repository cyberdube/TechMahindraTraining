import { Component } from '@angular/core';

@Component({
  selector: 'app-expense-tracker',
  templateUrl: './expense-trackerapp.component.html',
  styleUrls: ['./expense-trackerapp.component.css']
})
export class ExpenseTrackerComponent {
  transactions: any[] = [];
  newTransaction: any = {
    description: '',
    amount: 0,
    type: '',
    category: '',
    date: ''
  };

  addTransaction() {
    this.transactions.push({...this.newTransaction});
    this.newTransaction = {
      description: '',
      amount: 0,
      type: '',
      category: '',
      date: ''
    };
  }

  getTotalIncome() {
    return this.transactions
      .filter(t => t.type === 'income')
      .reduce((sum, t) => sum + t.amount, 0);
  }

  getTotalExpenses() {
    return this.transactions
      .filter(t => t.type === 'expense')
      .reduce((sum, t) => sum + t.amount, 0);
  }

  getBalance() {
    return this.getTotalIncome() - this.getTotalExpenses();
  }
}
