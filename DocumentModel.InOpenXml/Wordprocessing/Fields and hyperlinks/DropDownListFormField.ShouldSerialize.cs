namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DropDownListFormField
{
  public bool ShouldSerializeDropDownListSelection() => DropDownListSelection is not null;
  public bool ShouldSerializeDefaultDropDownListItemIndex() => DefaultDropDownListItemIndex is not null;
  public bool ShouldSerializeListEntryFormFields() => ListEntryFormFields is not null;
}
