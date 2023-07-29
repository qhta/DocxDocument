namespace ModelGenApp.ViewModels;

public class EnumTypeInfoViewModel : TypeInfoViewModel
{
  public EnumTypeInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(phase, typeInfo, typeNameSelector)
  {
    EnumValues = new EnumListViewModel(this, "EnumValues");
    if (typeInfo.EnumValues != null)
      foreach (var enumVal in typeInfo.EnumValues)
        EnumValues.Add(new EnumInfoViewModel(phase, enumVal, typeNameSelector));
  }

  [DataGridColumn(ResourceDataTemplateKey = "CountColumnTemplate",
    SortMemberPath = "EnumValues.Count", ClipboardContentPath = "EnumValues.Count",
    DisplayIndex = 3, Header = "Enum vals")]
  public EnumListViewModel EnumValues { get; set; }

  public override object? Members => EnumValues;

}
