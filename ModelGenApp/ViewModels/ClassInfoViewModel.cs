namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, NKS typeNameSelector) : base(phase, typeInfo, typeNameSelector)
  {
    Properties = new PropListViewModel(this, "Properties");
    //FillProperties();
  }

  [DataGridColumn(ResourceDataTemplateKey = "CountColumnTemplate",
    SortMemberPath = "Properties.Count", ClipboardContentPath = "Properties.Count",
    DisplayIndex = 3)]
  public PropListViewModel Properties { get; set; }

  public override object? Members => Properties;

  public override void FillDetails() => FillProperties();

  public void FillProperties()
  {
    Properties.Clear();
    foreach (var propInfo in Model.GetAllProperties())
      Properties.Add(new PropInfoViewModel(Phase, this, propInfo, TypeNameSelector));
  }

  protected override void FillTypeSummary()
  {
    if (Model.Type.Name.StartsWith("OpenXmlComparableSimpleValue") && Model.Type.IsConstructedGenericType)
      Debug.Assert(true);
    base.FillTypeSummary();
    var baseClass = Model.BaseTypeInfo;
    if (baseClass != null)
      TypeSummary.Add(new TypePropViewModel("Inheritance", TypeInfoViewModel.Create(Phase, baseClass, TypeNameSelector)));
  }
}
