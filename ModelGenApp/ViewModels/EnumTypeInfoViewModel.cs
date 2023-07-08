namespace ModelGenApp.ViewModels;

public class EnumTypeInfoViewModel : TypeInfoViewModel
{
  public EnumTypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    EnumValues = new EnumListViewModel(this, "Enum values");
    if (typeInfo.EnumValues != null)
      foreach (var enumVal in typeInfo.EnumValues)
        EnumValues.Add(new EnumInfoViewModel(enumVal, original));
  }

  [DataGridColumn(Header = "Enum values", DisplayIndex = 4)]
  public EnumListViewModel EnumValues { get; set; }
}
