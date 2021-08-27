<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603459/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1118)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* **[XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))**
<!-- default file list end -->
# How to simulate the mail merge feature for summary fields


<p>This example demonstrates a way in which to simulate the mail merge feature for summary fields, since this isn't supported in the current XtraReports version.</p><p>For this, handle the <strong>SummaryCalculated</strong> event of the label control displaying the summary. Note that the <strong>Tag</strong> property of the label control should be bound to a required data field to be included into the label's text.</p>

<br/>


