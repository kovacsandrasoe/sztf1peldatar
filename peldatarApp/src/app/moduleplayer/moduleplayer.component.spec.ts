import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModuleplayerComponent } from './moduleplayer.component';

describe('ModuleplayerComponent', () => {
  let component: ModuleplayerComponent;
  let fixture: ComponentFixture<ModuleplayerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModuleplayerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModuleplayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
