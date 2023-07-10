namespace ModelGenApp.ViewModels;

public class EnumTypeInfoViewModel : TypeInfoViewModel
{
  public EnumTypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    EnumValues = new EnumListViewModel(this, "EnumValues");
    if (typeInfo.EnumValues != null)
      foreach (var enumVal in typeInfo.EnumValues)
        EnumValues.Add(new EnumInfoViewModel(enumVal, original));
  }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate",
    SortMemberPath = "EnumValues.Count", ClipboardContentPath = "EnumValues.Count",
    DisplayIndex = 3, Header = "Enum vals")]
  public EnumListViewModel EnumValues { get; set; }

  public override object? Members => EnumValues;

}
