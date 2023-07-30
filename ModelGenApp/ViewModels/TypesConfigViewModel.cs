namespace ModelGenApp.ViewModels;
public class TypesConfigViewModel : ModelConfigViewModel
{
  public TypesConfigViewModel(ModelConfig configData) : base(configData)
  {
    Caption = "Model configuration: types";
    Types = new DispatchedCollection<TypeConfigViewModel>();
    Items = Types;
    GetData(configData);
  }

  public DispatchedCollection<TypeConfigViewModel> Types { get; private set; }

  public override void GetData(ModelConfig configData)
  {
    base.GetData(configData);
    var types = _Assembly.GetExportedTypes()
      .OrderBy(ti => ti.Name)
      .ToList();
    var fullNameComparison = configData.IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    foreach (var type in types)
    {
      if (type != null)
      {
        var fullTypeName = (type.Namespace ?? "") + "." + type.Name;

        var item = new TypeConfigViewModel { OrigNamespace = type.Namespace ?? "", OrigName = type.Name };
        item.ExcludedNamespace = configData.ExcludedNamespaces.Contains(type.Namespace ?? "");
        if (fullNameComparison)
        {
          item.Excluded = configData.ExcludedTypes.Contains(fullTypeName);
          item.Included = configData.IncludedTypes.Contains(fullTypeName);
        }
        else
        {
          item.Excluded = configData.ExcludedTypes.Contains(type.Name);
          item.Included = configData.IncludedTypes.Contains(type.Name);
        }
        if (configData.TypeConversion.TryGetValue(fullTypeName, out var conversion))
        {
          var k = conversion.LastIndexOf('.');
          if (k > 0 && k < conversion.Length - 1)
          {
            item.TargetNamespace = conversion.Substring(0, k);
            item.TargetName = conversion.Substring(k + 1);
          }
        }
        Types.Add(item);
      }
    }
  }

  public override void SetData(ModelConfig configData)
  {
    configData.IncludedTypes.Clear();
    configData.ExcludedTypes.Clear();
    configData.TypeConversion.Clear();
    foreach (var item in Types)
    {
      var fullTypeName = item.OrigNamespace + "." + item.OrigName;
      if (item.Included)
        configData.IncludedTypes.Add(fullTypeName);
      if (item.Excluded)
        configData.ExcludedTypes.Add(fullTypeName);
      if (item.TargetNamespace != null && item.TargetName != null)
      {
        configData.TypeConversion.Add(fullTypeName, item.TargetNamespace+"."+item.TargetName);
      }
    }
  }

  public override bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    return ok;
  }

  public override void AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigNamespace))
    {
      args.Column.Header = "Original namespace";
      args.Column.IsReadOnly = true;
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigName))
    {
      args.Column.Header = "Original name";
      args.Column.IsReadOnly = true;
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.ExcludedNamespace))
    {
      args.Column.Header = "Excl. n-s";
      args.Column.IsReadOnly = true;
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.Included))
    {
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.Excluded))
    {
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.TargetNamespace))
    {
      args.Column.Header = "Target namespace";
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.TargetName))
    {
      args.Column.Header = "Target name";
      args.Cancel = false;
    }
    else
      args.Cancel = true;
  }
}
