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
    DisplayIndex = 5)]
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
    await Task.Factory.StartNew(() => FillProperties());
  }

  public void FillProperties()
  {
    if (_Properties == null)
      return;
    Properties.Clear();
    foreach (var propInfo in Model.GetAllProperties().Where(item=>item.AddedInPhase<=Phase.PhaseNum).ToList())
      Properties.Add(new PropInfoViewModel(Phase, this, propInfo, TypeNameSelector));
  }

  public async void RefreshPropertiesAsync()
  {
    await Task.Factory.StartNew(() => RefreshProperties());
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
    if (!_TypeSummary.IsEmpty) return;
    base.FillTypeSummary();
    var baseClass = Model.BaseTypeInfo;
    if (baseClass != null)
      _TypeSummary.Add(new TypePropViewModel(CommonStrings.BaseType, TypeInfoViewModel.Create(Phase, baseClass, TypeNameSelector)));
    var derivedClasses = Model.GetIncomingRelationships(Semantics.Inheritance).Select(item=>item.Source).ToList();
    if (derivedClasses.Any())
    {
      var info= new TypeListViewModel(Phase, null, "derived types", TypeNameSelector, TKS.Class, null);
      info.Items.AddRange(derivedClasses.Select(item=>TypeInfoViewModel.Create(Phase, item, TypeNameSelector)));
      _TypeSummary.Add(new TypePropViewModel(CommonStrings.DerivedTypes, info));
    }
  }

  public override void RefreshDetails()
  {
    base.RefreshDetails();
    RefreshProperties();
  }
}
