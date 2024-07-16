import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DemopComponent } from './demop.component';

describe('DemopComponent', () => {
  let component: DemopComponent;
  let fixture: ComponentFixture<DemopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DemopComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DemopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
