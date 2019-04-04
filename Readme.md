<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_SaveLoadCollapsedState/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_SaveLoadCollapsedState/Form1.vb))
<!-- default file list end -->
# How to Restore the Pivot Grid's Layout


This example demonstrates how to restore the Pivot Grid's layout and the row/column collapsed state.

The **Save** button uses the [PivotGridControl.SaveLayoutToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveLayoutToStream.overloads) and [PivotGridControl.SaveCollapsedStateToStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.SaveCollapsedStateToStream(System.IO.Stream)) methods to save the layout and field values' collapsed state to memory streams.

The **Load** button uses the [PivotGridControl.RestoreLayoutFromStream ](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RestoreLayoutFromStream.overloads) and [PivotGridControl.LoadCollapsedStateFromStream](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.LoadCollapsedStateFromStream(System.IO.Stream)) methods.

![screenshot](https://github.com/DevExpress-Examples/how-to-save-load-field-values-collapsed-states-together-with-pivot-grids-layout-e20014/blob/13.1.4%2B/images/screenshot.png)
