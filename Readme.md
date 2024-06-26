<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582478/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20014)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_SaveLoadCollapsedState/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_SaveLoadCollapsedState/Form1.vb))
<!-- default file list end -->
# How to save/load field values' collapsed states together with pivot grid's layout


<p>Field values' collapsed states can be restored only in the same layout they have been saved in. This example shows how to save and load a control's layout together with collapsed states to ensure that the states are loaded in the appropriate layout.</p><p>This example displays a pivot grid control and three buttons: Save, Load and Clear. When the Save button is clicked, the control layout and field values' collapsed states are saved to streams via the SaveLayoutToStream and SaveCollapsedStateToStream methods, respectively. On the Load button click, the RestoreLayoutFromStream method is firstly called to restore the layout, and then the collapsed states are loaded using the LoadCollapsedStateFromStream method. This ensures that even if you remove all fields from the pivot grid via the Clear button, the control's state will be restored when you click the Load button.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-save-restore-state-and-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-save-restore-state-and-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
