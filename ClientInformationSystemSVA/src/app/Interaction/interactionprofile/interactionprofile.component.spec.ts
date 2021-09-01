import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InteractionprofileComponent } from './interactionprofile.component';

describe('InteractionprofileComponent', () => {
  let component: InteractionprofileComponent;
  let fixture: ComponentFixture<InteractionprofileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InteractionprofileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InteractionprofileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
