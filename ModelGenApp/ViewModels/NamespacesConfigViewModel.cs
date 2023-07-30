namespace ModelGenApp.ViewModels;
public class NamespacesConfigViewModel : ModelConfigViewModel
{
  public NamespacesConfigViewModel(ModelConfig configData) : base(configData)
  {
    Caption = "Model configuration: namespaces";
    Namespaces = new DispatchedCollection<NamespaceConfigViewModel>();
    Items = Namespaces;
    GetData(configData);
  }

  public DispatchedCollection<NamespaceConfigViewModel> Namespaces { get; private set; }

  public override void GetData(ModelConfig configData)
  {
    base.GetData(configData);
    var nsNames = _Assembly.GetExportedTypes()
      .Select(t => t.Namespace)
      .GroupBy(ns => ns)
      .Select(grp => grp.Key)
      .OrderBy(name => name)
      .ToList();
    foreach (var ns in nsNames)
    {
      if (ns != null)
      {
        var item = new NamespaceConfigViewModel { OrigName = ns };
        item.Excluded = configData.ExcludedNamespaces.Contains(ns);
        if (configData.NamespaceShortcuts.TryGetValue(ns, out var shortcut))
          item.Shortcut = shortcut;
        if (configData.TranslatedNamespaces.TryGetValue(ns, out var translated))
          item.TargetName = translated;
        if (translated != null)
          if (configData.NamespaceShortcuts.TryGetValue(translated, out var shortcut2))
            item.TargetShortcut = shortcut2;
        Namespaces.Add(item);
      }
    }
  }

  public override void SetData(ModelConfig configData)
  {
    configData.ExcludedNamespaces.Clear();
    configData.NamespaceShortcuts.Clear();
    configData.TranslatedNamespaces.Clear();
    foreach (var item in Namespaces)
    {
      if (item.Excluded)
        configData.ExcludedNamespaces.Add(item.OrigName);
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
        configData.NamespaceShortcuts.Add(item.OrigName, item.Shortcut);
      if (!String.IsNullOrWhiteSpace(item.TargetName))
        configData.TranslatedNamespaces.Add(item.OrigName, item.TargetName);
      if (!String.IsNullOrEmpty(item.TargetShortcut) && !String.IsNullOrWhiteSpace(item.TargetName))
      {
        if (!configData.NamespaceShortcuts.TryGetValue2(item.TargetName, out _))
          configData.NamespaceShortcuts.Add(item.TargetName, item.TargetShortcut);
      }
    }
  }

  public override bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    if (!ValidateShortcuts(configData))
      ok = false;
    if (!ValidateTargetShortcuts(configData))
      ok = false;
    return ok;
  }

  public bool ValidateShortcuts(ModelConfig configData)
  {
    var ok = true;
    // Names are unique, so we must check only if a shortcut already exists.
    var knownShortcuts = new List<string>();
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      string? errorMsg = null;
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
      {
        if (knownShortcuts.Contains(item.Shortcut))
        {
          isValid = false;
          errorMsg = "Duplicated shortcut";
        }
        else
          knownShortcuts.Add(item.Shortcut);
      }
      item.IsShortcutValid = isValid;
      item.ShortcutErrorMsg = errorMsg;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  public bool ValidateTargetShortcuts(ModelConfig configData)
  {
    var ok = true;
    // Target names are not unique, so we must check if a target shortcut already exists with a different target name.
    var knownTargetShortcuts = new Dictionary<string, string?>();
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      string? errorMsg = null;
      if (!String.IsNullOrWhiteSpace(item.TargetShortcut))
      {
        if (knownTargetShortcuts.TryGetValue(item.TargetShortcut, out var targetName))
        {
          if (targetName != item.TargetName)
          {
            isValid = false;
            errorMsg = "Duplicated target shortcut";
          }
        }
        else
          knownTargetShortcuts.Add(item.TargetShortcut, item.TargetName);
      }
      item.IsTargetShortcutValid = isValid;
      item.TargetShortcutErrorMsg = errorMsg;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  public override void AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (args.PropertyName == nameof(NamespaceConfigViewModel.OrigName))
    {
      args.Column.Header = "Original name";
      args.Column.IsReadOnly = true;
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.Excluded))
    {
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.Shortcut))
    {
      var column = new DataGridTemplateColumn();
      column.Header = "Shortcut";
      column.CellTemplate = Application.Current.FindResource("ShortcutCellTemplate") as DataTemplate;
      column.CellEditingTemplate = Application.Current.FindResource("ShortcutCellEditingTemplate") as DataTemplate;
      args.Column = column;
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.TargetName))
    {
      args.Column.Header = "Target name";
      args.Cancel = false;
    }
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.TargetShortcut))
    {
      var column = new DataGridTemplateColumn();
      column.Header = "Target shortcut";
      column.CellTemplate = Application.Current.FindResource("TargetShortcutCellTemplate") as DataTemplate;
      column.CellEditingTemplate = Application.Current.FindResource("TargetShortcutCellEditingTemplate") as DataTemplate;
      args.Column = column;
      args.Cancel = false;
    }
    else
      args.Cancel = true;
  }

}
