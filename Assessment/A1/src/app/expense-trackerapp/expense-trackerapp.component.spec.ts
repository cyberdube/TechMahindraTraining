import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms'; // Import FormsModule
import { ExpenseTrackerComponent } from './expense-trackerapp.component';

describe('ExpenseTrackerComponent', () => {
  let component: ExpenseTrackerComponent;
  let fixture: ComponentFixture<ExpenseTrackerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExpenseTrackerComponent ],
      imports: [ FormsModule ] // Add FormsModule to imports
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExpenseTrackerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
