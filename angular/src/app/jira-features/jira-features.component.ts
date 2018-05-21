import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { JiraFeatureServiceProxy, JiraFeatureDto, PagedResultDtoOfJiraFeatureDto } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";


@Component({
    selector: 'jira-features',
    templateUrl: './jira-features.component.html',
    animations: [appModuleAnimation()]
})
export class JiraFeaturesComponent extends PagedListingComponentBase<JiraFeatureDto> {
  
    active: boolean = false;
    jiraFeatures: JiraFeatureDto[] = [];

    constructor(
        injector: Injector,
        private _jiraFeatureService: JiraFeatureServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        console.log("Hello",request);
        this._jiraFeatureService.getAll(request.skipCount, request.maxResultCount)
            .finally(() => {
                finishedCallback();
            })
            .subscribe((result: PagedResultDtoOfJiraFeatureDto) => {
                this.jiraFeatures = result.items;
                this.showPaging(result, pageNumber);
            });
    }

    protected delete(jiraFeature: JiraFeatureDto): void {
        abp.message.confirm(
            "Delete user '" + jiraFeature.key + "'?",
            (result: boolean) => {
                if (result) {
                  //  this._jiraFeatureService.delete(jiraFeature.id)
                      //  .subscribe(() => {
                        //    abp.notify.info("Deleted User: " + jiraFeature.key);
                          //  this.refresh();
                       // });
                }
            }
        );
    }

   
}