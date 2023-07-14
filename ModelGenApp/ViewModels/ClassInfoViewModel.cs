namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    Properties = new PropListViewModel(this, "Properties");
    if (typeInfo.Properties != null)
      foreach (var propInfo in typeInfo.Properties)
        Properties.Add(new PropInfoViewModel(this, propInfo, original));
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
        if (targetType!=null)
          TypeSummaryVM.Add(new TypePropViewModel("Inheritance", new TypeInfoViewModel(targetType, Original)));
      }
  }
}
