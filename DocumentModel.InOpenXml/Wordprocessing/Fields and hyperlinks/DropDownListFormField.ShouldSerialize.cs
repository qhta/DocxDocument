namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DropDownListFormField
{
  public bool ShouldSerializeDropDownListSelection() => DropDownListSelection is not null && ShouldSerialize(DropDownListSelection);
  public bool ShouldSerializeDefaultDropDownListItemIndex() => DefaultDropDownListItemIndex is not null && ShouldSerialize(DefaultDropDownListItemIndex);
  public bool ShouldSerializeListEntryFormFields() => ListEntryFormFields is not null && ShouldSerialize(ListEntryFormFields);
}
