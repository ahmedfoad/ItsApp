import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
} from "@angular/core";
import { finalize } from "rxjs/operators";
import { BsModalRef } from "ngx-bootstrap/modal";
import { AppComponentBase } from "@shared/app-component-base";
import {
  InformationServiceServiceProxy,
  InformationDto,
} from "@shared/service-proxies/service-proxies";
import { forEach as _forEach, map as _map } from "lodash-es";

@Component({
  selector: "app-edit-information",
  templateUrl: "./edit-information.component.html",
  styleUrls: ["./edit-information.component.css"],
  providers: [InformationServiceServiceProxy],
})
export class EditInformationComponent
  extends AppComponentBase
  implements OnInit
{
  information = new InformationDto();
  saving = false;
  currentStep: number;
  id: number;
  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private informationService: InformationServiceServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    debugger;
    this.informationService.get(this.id).subscribe((result: InformationDto) => {
      this.information = result;
    });
  }

  save(): void {
    debugger;
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
        this.notify.info(this.l("SavedSuccessfully"));
        this.bsModalRef.hide();
        this.onSave.emit();
      });
  }
}
