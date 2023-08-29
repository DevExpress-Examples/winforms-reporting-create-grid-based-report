<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599091/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E108)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Reporting - Create a Report from the DevExpress GridControl 

This example demonstrates two techniques (methods) that allow you to do the following:

* Create a grid-based report in code.
* Preview the report at runtime.
* Load the report in the Report Designer.

## Ribbon UI

The Ribbon UI includes the following options:

* **DataTable Conversion** - Demonstrates how to use the intermediate DataTable.
* **Report Generator Conversion** - Uses the `ReportGenerator` class from the Reporting Extensions library that ships as part of the DevExpress installation. 


## DataTable Method

The [GridView.GetVisibleRowHandle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.GetVisibleRowHandle(System.Int32)) method is used to obtain visible data rows. A [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable) is created and passed to the report constructor in the code-behind file. The report constructor uses the `GridView` to create a report layout at runtime. The [XRTable](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRTable) structure is composed of grid column captions. Grouped columns generate the [GroupHeaderBand](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.GroupHeaderBand) in the report.

## ReportGenerator Method

The [ReportGenerator.GenerateReport](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.ReportGeneration.ReportGenerator.GenerateReport.overloads) method creates a report from the [GridView](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView) and allows you to specify the 
[report generation options](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraReports.ReportGeneration.ReportGenerationOptions._members).



![Report preview with data from expanded rows in the GridControl](Images/screenshot.png)

The example uses the SQLite database with Northwind data.
 
<!-- default file list -->

## Files to Review

* [Form1.cs](CS/ConvertGridToReportExample/Form1.cs) (VB: [Form1.vb](VB/ConvertGridToReportExample/Form1.vb))
* [XtraReport1.cs](CS/ConvertGridToReportExample/XtraReport1.cs) (VB: [XtraReport1.vb](VB/ConvertGridToReportExample/XtraReport1.vb))

<!-- default file list end -->

## Documentation

- [Convert DevExpress Data Grid to Report](https://docs.devexpress.com/XtraReports/119218/get-started-with-devexpress-reporting/convert-a-devexpress-data-grid-to-a-report)
- [Advanced Grid Printing and Exporting](https://docs.devexpress.com/WindowsForms/114962/controls-and-libraries/data-grid/export-and-printing/advanced-grid-printing-and-exporting)
- [Generate a Grid-Based Report (WPF)](https://docs.devexpress.com/WPF/117300/controls-and-libraries/data-grid/printing-and-exporting/grid-based-report-generation)
