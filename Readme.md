<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582478/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20014)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to Save and Restore the Pivot Grid's Layout

This example demonstrates how to restore the Pivot Grid's layout and rows/columns state.

![screenshot](./images/screenshot.png)

The **Save** button uses the [PivotGridControl.SaveLayoutToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveLayoutToStream.overloads) and [PivotGridControl.SaveCollapsedStateToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveCollapsedStateToStream(System.IO.Stream)) methods to save the layout and field values' collapsed state to memory streams.

The **Load** button uses the [PivotGridControl.RestoreLayoutFromStream ](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RestoreLayoutFromStream.overloads) and [PivotGridControl.LoadCollapsedStateFromStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.LoadCollapsedStateFromStream(System.IO.Stream)) methods to restore the saved layout and columns/rows state.

The **Clear** button clears the field collection.

## Files to Review

[Form1.cs](./CS/XtraPivotGrid_RestoreLayoutExample/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_RestoreLayoutExample/Form1.vb))

## Documentation

[Save and Restore Layout](https://docs.devexpress.com/WindowsForms/1806/controls-and-libraries/pivot-grid/layout/save-and-restore-layout)

## More Examples

[ASPxPivotGrid - How to Manage Pivot Grid Layout](https://github.com/DevExpress-Examples/aspxpivotgrid-layout-upgrade-event)
