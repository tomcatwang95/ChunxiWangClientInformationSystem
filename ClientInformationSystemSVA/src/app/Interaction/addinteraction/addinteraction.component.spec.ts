import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddinteractionComponent } from './addinteraction.component';

describe('AddinteractionComponent', () => {
  let component: AddinteractionComponent;
  let fixture: ComponentFixture<AddinteractionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddinteractionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddinteractionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
