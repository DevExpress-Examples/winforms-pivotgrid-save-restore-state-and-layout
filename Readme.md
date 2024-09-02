<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582478/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20014)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Save and Restore the Pivot Grid Layout

This example demonstrates how to restore the Pivot Grid layout and row/column state.


![screenshot](./images/screenshot.png)

The **Save** button uses the [PivotGridControl.SaveLayoutToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveLayoutToStream.overloads) and [PivotGridControl.SaveCollapsedStateToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveCollapsedStateToStream(System.IO.Stream)) methods to save the layout and field values' collapsed state to memory streams.

The **Load** button uses the [PivotGridControl.RestoreLayoutFromStream ](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RestoreLayoutFromStream.overloads) and [PivotGridControl.LoadCollapsedStateFromStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.LoadCollapsedStateFromStream(System.IO.Stream)) methods to restore the saved layout and column/row state.

The **Clear** button clears the field collection.

## Files to Review

[Form1.cs](./CS/XtraPivotGrid_RestoreLayoutExample/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_RestoreLayoutExample/Form1.vb))

## Documentation

[Save and Restore Layout](https://docs.devexpress.com/WindowsForms/1806/controls-and-libraries/pivot-grid/layout/save-and-restore-layout)

## More Examples

[ASPxPivotGrid - How to Manage Pivot Grid Layout](https://github.com/DevExpress-Examples/aspxpivotgrid-layout-upgrade-event)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-save-restore-state-and-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-save-restore-state-and-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
