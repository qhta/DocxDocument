namespace ModelGenApp.ViewModels;
public class NamespacesConfigViewModel : ModelConfigViewModel
{
  public NamespacesConfigViewModel(ModelConfig configData) : base(configData)
  {
    Caption = CommonStrings.ModelConfiguration_ + " " + CommonStrings.Namespaces.ToLower();
    Namespaces = new ObservableCollection<NamespaceConfigViewModel>();
    Items = Namespaces;
    GetData(configData);
  }

  public ObservableCollection<NamespaceConfigViewModel> Namespaces { get; private set; }

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
          if (configData.NamespaceShortcuts.TryGetValue(translated, out var targetShortcut))
            item.TargetShortcut = targetShortcut;
        item.PropertyChanged += Item_PropertyChanged;
        Namespaces.Add(item);
      }
    }
    ValidateData();
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (e.PropertyName == nameof(NamespaceConfigViewModel.Shortcut)
      || e.PropertyName == nameof(NamespaceConfigViewModel.TargetShortcut)
      || e.PropertyName == nameof(NamespaceConfigViewModel.TargetName))
      ValidateData();
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

  public override bool ValidateData()
  {
    var ok = true;
    if (!ValidateShortcuts())
      ok = false;
    if (!ValidateTargetShortcuts())
      ok = false;
    NotifyPropertyChanged(nameof(AreAllShortcutsValid));
    NotifyPropertyChanged(nameof(AreAllTargetShortcutsValid));
    return ok;
  }

  public bool ValidateShortcuts()
  {
    var ok = true;
    // Names are unique, so we must check only if a shortcut already exists.
    var knownShortcuts = new List<string>();
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
      {
        if (knownShortcuts.Contains(item.Shortcut))
        {
          isValid = false;
        }
        else
          knownShortcuts.Add(item.Shortcut);
      }
      item.IsShortcutValid = isValid;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  public bool ValidateTargetShortcuts()
  {
    var ok = true;
    // Target names are not unique, so we must check if a target shortcut already exists with a different target name.
    var knownTargetShortcuts = new Dictionary<string, string?>();  // target shortcut to target name mapping
    // We must also check if a target name already is mapped to different target shortcut
    var knownTargetNames = new Dictionary<string, string?>(); // target name to target shortcut mapping
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      if (!String.IsNullOrWhiteSpace(item.TargetShortcut))
      {
        if (knownTargetShortcuts.TryGetValue(item.TargetShortcut, out var targetName))
        {
          if (targetName != item.TargetName)
          {
            isValid = false;
          }
        }
        else
          knownTargetShortcuts.Add(item.TargetShortcut, item.TargetName);
      }
      if (!String.IsNullOrWhiteSpace(item.TargetName))
      {
        if (knownTargetNames.TryGetValue(item.TargetName, out var targetShortcut))
        {
          if (targetShortcut != item.TargetShortcut)
          {
            isValid = false;
          }
        }
        else
          knownTargetNames.Add(item.TargetName, item.TargetShortcut);
      }
      item.IsTargetShortcutValid = isValid;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  public bool AreAllShortcutsValid => Items.Cast<NamespaceConfigViewModel>().Any(item => !item.IsShortcutValid);

  public bool AreAllTargetShortcutsValid => Items.Cast<NamespaceConfigViewModel>().Any(item => !item.IsTargetShortcutValid);

}
