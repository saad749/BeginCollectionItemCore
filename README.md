# BeginCollectionItemCore

## Usage

```C#
@using HtmlHelpers.BeginCollectionItemCore;
@model BeginCollectionItemCoreDemo.ViewModels.OrderItemModel


@using (Html.BeginCollectionItem("orderItems"))
{
    @Html.LabelFor(x => x.Title);
    @Html.EditorFor(x => x.Title);
    @Html.LabelFor(x => x.Quantity);
    @Html.EditorFor(x => x.Quantity);
}
```


## Release Notes:
- 1.1.0: Updated to Target .Net 5.0
- 1.0.9: Updated to Target .Net Core 2.0
- 1.0.8: Server Side Validation Issue Fixed
- 1.0.7: Bug Fixes for Nested Collections Support
- 1.0.6: Fixed Version Number
- 1.0.5: Added Support for Nested Collections  
- 1.0.4: Added Support for ASP.Net Core on .Net Framework 4.6