import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonalAreaSettingsComponent } from './personal-area-settings.component';

describe('PersonalAreaSettingsComponent', () => {
  let component: PersonalAreaSettingsComponent;
  let fixture: ComponentFixture<PersonalAreaSettingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonalAreaSettingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonalAreaSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
