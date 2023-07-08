using Qhta.MVVM;

namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    Properties = new PropListViewModel(this, "Properties");
    if (typeInfo.Properties!=null)
      foreach (var propInfo in typeInfo.Properties)
        Properties.Add(new PropInfoViewModel(propInfo, original));
  }

  [DataGridColumn(DisplayIndex = 4)]
  public PropListViewModel Properties { get; set; }
}
