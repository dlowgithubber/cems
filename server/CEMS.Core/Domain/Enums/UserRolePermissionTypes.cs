using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CEMS.Core.Domain.Enums
{
    public enum UserRolePermissionTypes
    {
        [Display(Name = "Users:Administer")]
        UsersAdminister,
        [Display(Name = "Flows:Administer")]
        FlowsAdminister,
        [Display(Name = "Person:View")]
        PersonView,
        [Display(Name = "Person:Modify")]
        PersonModify,
        [Display(Name = "Person:ViewSensitive")]
        PersonViewSensitive,
        [Display(Name = "Person:ModifySensitive")]
        PersonModifySensitive,
        [Display(Name = "Site:View")]
        SiteView,
        [Display(Name = "Site: Modify")]
        SiteModify,
        [Display(Name = "Event:View")]
        EventView,
        [Display(Name = "Event:ModifyTeams")]
        EventModifyTeams,
        [Display(Name = "Event:ModifySites")]
        EventModifySites,
        [Display(Name = "Report:View")]
        ReportView,
        [Display(Name = "Report:Modify")]
        ReportModify,
        [Display(Name = "MutableRecord:View")]
        MutableRecordView,
        [Display(Name = "MutableRecord:Modify")]
        MutableRecordModify,
        [Display(Name = "MedicalRecord:View")]
        MedicalRecordView,
        [Display(Name = "MedicalRecord:Add")]
        MedicalRecordAdd,
        [Display(Name = "IncidentReport:View")]
        IncidentReportView,
        [Display(Name = "IncidentReport:Add")]
        IncidentReportAdd
    }
}
