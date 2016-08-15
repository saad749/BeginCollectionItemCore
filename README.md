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
