namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    Properties = new PropListViewModel(this, "Properties");
    if (typeInfo.Properties != null)
      foreach (var propInfo in typeInfo.Properties)
        Properties.Add(new PropInfoViewModel(propInfo, original));
  }

  [DataGridColumn(ResourceDataTemplateKey = "CollectionCountColumnTemplate",
    SortMemberPath = "Properties.Count", ClipboardContentPath = "Properties.Count",
    DisplayIndex = 3)]
  public PropListViewModel Properties { get; set; }

  public override object? Members => Properties;
}
