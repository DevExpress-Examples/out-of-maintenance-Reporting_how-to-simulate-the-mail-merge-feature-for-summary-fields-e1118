# How to simulate the mail merge feature for summary fields


<p>This example demonstrates a way in which to simulate the mail merge feature for summary fields, since this isn't supported in the current XtraReports version.</p><p>For this, handle the <strong>SummaryCalculated</strong> event of the label control displaying the summary. Note that the <strong>Tag</strong> property of the label control should be bound to a required data field to be included into the label's text.</p>

<br/>


