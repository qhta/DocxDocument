using System.Buffers;

namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(PhaseResultsViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(phase, typeInfo, typeNameSelector)
  {
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Properties),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.PropertiesTooltip),
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Properties.Count",
    ClipboardContentPath = "Properties.Count",
    DisplayIndex = 3)]
  public PropListViewModel Properties
  {
    get
    {
      if (_Properties == null)
      {
        _Properties = new PropListViewModel(Phase, this, "Properties", TypeNameSelector);
        FillPropertiesAsync();
      }
      return _Properties;
    }
  }
  private PropListViewModel _Properties = null!;

  public override object? Members => Properties;

  public override void FillDetails()
  {
    base.FillDetails();
    FillPropertiesAsync();
  }

  public async void FillPropertiesAsync()
  {
    await Task.Run(() => FillProperties());
  }

  public void FillProperties()
  {
    if (_Properties == null)
      return;
    Properties.Clear();
    foreach (var propInfo in Model.GetAllProperties().ToList())
      Properties.Add(new PropInfoViewModel(Phase, this, propInfo, TypeNameSelector));
  }

  public async void RefreshPropertiesAsync()
  {
    await Task.Run(() => RefreshProperties());
  }

  public void RefreshProperties()
  {
    if (_Properties == null)
      return;
    Properties.ShowFullTypeName = this.ShowFullTypeName;
    var properties = Model.GetAllProperties().ToList();
    var newProperties = new List<PropInfo>();
    foreach (var propInfo in properties)
      if (!Properties.Any(vm => vm.Model == propInfo))
        newProperties.Add(propInfo);
    foreach (var propInfo in newProperties)
      Properties.Add(new PropInfoViewModel(Phase, this, propInfo, TypeNameSelector));
  }

  protected override void FillTypeSummary()
  {
    base.FillTypeSummary();
    var baseClass = Model.BaseTypeInfo;
    if (baseClass != null)
      TypeSummary.Add(new TypePropViewModel("Inheritance", TypeInfoViewModel.Create(Phase, baseClass, TypeNameSelector)));
  }

  public override void RefreshDetails()
  {
    base.RefreshDetails();
    RefreshProperties();
  }
}
