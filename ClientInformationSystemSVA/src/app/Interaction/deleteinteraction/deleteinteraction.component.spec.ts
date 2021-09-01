import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteinteractionComponent } from './deleteinteraction.component';

describe('DeleteinteractionComponent', () => {
  let component: DeleteinteractionComponent;
  let fixture: ComponentFixture<DeleteinteractionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleteinteractionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteinteractionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
