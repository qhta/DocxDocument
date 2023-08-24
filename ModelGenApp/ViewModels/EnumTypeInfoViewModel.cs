namespace ModelGenApp.ViewModels;

public class EnumTypeInfoViewModel : TypeInfoViewModel
{
  public EnumTypeInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(phase, typeInfo, typeNameSelector)
  {
    EnumValues = new EnumListViewModel(this, "EnumValues");
  }

  [DataGridColumn(DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "EnumValues.Count", ClipboardContentPath = "EnumValues.Count",
    DisplayIndex = 3, Header = "Enum vals")]
  public EnumListViewModel EnumValues { get; set; }

  public override object? Members => EnumValues;

  public override void FillDetails() => FillEnumValues();

  public async void FillEnumValuesAsync()
  {
    await Task.Run(() => FillEnumValues());
  }

  public void FillEnumValues()
  {
    EnumValues.Clear();
    if (Model.EnumValues != null)
      foreach (var enumVal in Model.EnumValues.ToList())
        EnumValues.Add(new EnumInfoViewModel(Phase, enumVal, TypeNameSelector));
  }


  public override void RefreshDetails() => RefreshEnumValues();

  public async void RefreshEnumValuesAsync()
  {
    await Task.Run(() => RefreshEnumValues());
  }

  public void RefreshEnumValues()
  {
    if (Model.EnumValues != null)
    {
      var enumValues = Model.EnumValues.ToList();
      var newEnumValues = new List<EnumInfo>();
      foreach (var enumInfo in enumValues)
        if (!EnumValues.Any(vm => vm.Model == enumInfo))
          newEnumValues.Add(enumInfo);

      foreach (var enumVal in newEnumValues)
        EnumValues.Add(new EnumInfoViewModel(Phase, enumVal, TypeNameSelector));
    }
  }


}
