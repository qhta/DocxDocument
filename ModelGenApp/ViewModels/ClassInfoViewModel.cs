namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(phase, typeInfo, typeNameSelector)
  {
    Properties = new PropListViewModel(this, "Properties");
    if (typeInfo.Properties != null)
      foreach (var propInfo in typeInfo.Properties)
        Properties.Add(new PropInfoViewModel(phase, this, propInfo, typeNameSelector));
  }

  [DataGridColumn(ResourceDataTemplateKey = "CountColumnTemplate",
    SortMemberPath = "Properties.Count", ClipboardContentPath = "Properties.Count",
    DisplayIndex = 3)]
  public PropListViewModel Properties { get; set; }

  public override object? Members => Properties;

  protected override void FillTypeSummaryVM()
  {
    base.FillTypeSummaryVM();
    var baseClasses = Model.GetOutgoingRelationships(Semantics.Inheritance);
    if (baseClasses.Any())
      foreach (var item in baseClasses)
      {
        var targetType = item.Target as TypeInfo;
        if (targetType != null)
          TypeSummaryVM.Add(new TypePropViewModel("Inheritance", new TypeInfoViewModel(Phase, targetType, TypeNameSelector)));
      }
  }
}
