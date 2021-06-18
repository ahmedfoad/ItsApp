import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
} from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/app-component-base';
import {
  InformationServiceServiceProxy,
  InformationDto
} from '@shared/service-proxies/service-proxies';
import { forEach as _forEach, map as _map } from 'lodash-es';

@Component({
  selector: 'app-create-information',
  templateUrl: './create-information.component.html',
  styleUrls: ['./create-information.component.css'],
  providers: [InformationServiceServiceProxy],
})
export class CreateInformationComponent  extends AppComponentBase implements OnInit {
  saving = false;
  information = new InformationDto();
  currentStep: number;
  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private informationService: InformationServiceServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
  }

  save(): void {
    this.saving = true;
    this.information.stepIndex = this.currentStep;

    this.informationService
      .createOrUpdate(this.information)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      });
  }

}
