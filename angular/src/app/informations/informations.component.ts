import { Component, Injector, OnInit } from "@angular/core";
import {
  InformationDto,
  InformationServiceServiceProxy,
} from "@shared/service-proxies/service-proxies";
import { AppComponentBase } from "@shared/app-component-base";
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from "ngx-bootstrap/modal";
import { CreateInformationComponent } from "./create-information/create-information.component";
import { EditInformationComponent } from "./edit-information/edit-information.component";

@Component({
  selector: "app-informations",
  templateUrl: "./informations.component.html",
  styleUrls: ["./informations.component.scss"],
  providers: [InformationServiceServiceProxy],
})
export class InformationsComponent extends AppComponentBase implements OnInit {
  public cuttentStepValue: Number = 1;
  public cuttentStepIndex: Number = 0;
  public Steps: Array<Number> = [];
  public lastStepValue: number;
  public informationList: Array<InformationDto> = [];
  constructor(
    public injector: Injector,
    private _modalService: BsModalService,
    private informationService: InformationServiceServiceProxy
  ) {
    super(injector);
  }

  ngOnInit() {
    this.getCurrentStep(this.cuttentStepValue);
    this.getSteps();
  }
  getCurrentStep(stepValue: Number) {
    console.log("step : " + stepValue.valueOf().toString);
    this.informationService
      .getByStepIndex(stepValue.valueOf())
      .subscribe((result) => {
        this.informationList = result;
        console.log(this.informationList);
      });
  }
  getSteps() {
    this.informationService.getStepIndexList().subscribe((result) => {
      this.Steps = result;
      console.log(this.Steps);
    });
  }
  next() {
    if (this.Steps.length > this.cuttentStepIndex.valueOf() + 1) {
      this.cuttentStepIndex = this.cuttentStepIndex.valueOf() + 1;
      this.cuttentStepValue = this.Steps[this.cuttentStepIndex.valueOf()];
      this.getCurrentStep(this.cuttentStepValue.valueOf());
    }
  }
  previous() {
    if (this.cuttentStepIndex > 0) {
      this.cuttentStepIndex = this.cuttentStepIndex.valueOf() - 1;
      this.cuttentStepValue = this.Steps[this.cuttentStepIndex.valueOf()];
      this.getCurrentStep(this.cuttentStepValue.valueOf());
    }
  }
  newStep() {
    debugger;
    this.lastStepValue = this.Steps[this.Steps.length - 1].valueOf();
    this.Steps.push(this.lastStepValue + 1);
    this.cuttentStepIndex = this.Steps.length - 1;
    this.cuttentStepValue = this.Steps[this.cuttentStepIndex.valueOf()];
    this.informationList = null;
  }
  removeStep(index: number) {
    debugger;
    abp.message.confirm(
      'Do you want to delete step ' + this.Steps[index].valueOf()  + ' ?',
      undefined,
      (result: boolean) => {
        if (result) {
          this.informationService
            .deleteByStepIndex(this.Steps[index].valueOf())
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.Steps.splice(index, 1);
                this.cuttentStepValue = 1;
                this.cuttentStepIndex = 0;
                this.getCurrentStep(this.cuttentStepValue.valueOf());
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  deleteItem(information: InformationDto): void {
    abp.message.confirm(
      'Do you want to delete item ' + information.id +  ' (title : ' + information.title + ') ?',
      undefined,
      (result: boolean) => {
        if (result) {
          this.informationService
            .delete(information.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.getCurrentStep(this.cuttentStepValue.valueOf());
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }


  createInformation(): void {
    this.showCreateOrEditInformationDialog();
  }

  editInformation(information: InformationDto): void {
    debugger;
    this.showCreateOrEditInformationDialog(information.id);
  }



  showCreateOrEditInformationDialog(id?: number): void {
    let createOrEditRoleDialog: BsModalRef;
    if (!id) {
      createOrEditRoleDialog = this._modalService.show(
        CreateInformationComponent,
        {
          class: 'modal-lg',
          initialState: {
            currentStep: this.cuttentStepValue.valueOf()
          },
        }
      );
    } else {
      createOrEditRoleDialog = this._modalService.show(
        EditInformationComponent,
        {
          class: 'modal-lg',
          initialState: {
            currentStep: this.cuttentStepValue.valueOf(),
            id: id,
          },
        }
      );
    }

    createOrEditRoleDialog.content.onSave.subscribe(() => {
      this.getCurrentStep(this.cuttentStepValue.valueOf());
    });
  }
}
