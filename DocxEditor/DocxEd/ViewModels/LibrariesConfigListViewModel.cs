namespace DocxEd.ViewModels;
public class LibrariesConfigListViewModel : ConfigListViewModel<LibraryConfigViewModel>
{
  public LibrariesConfigListViewModel(ModelConfigViewModel owner): base(owner)
  {
  }

  public void CreateItems(ModelConfigData configData)
  {
    var targetLibraries = configData.TargetLibraries;
    foreach (var aName in Owner.ReferencedAssemblyNames)
    {
      var item = new LibraryConfigViewModel { Name = aName.FullName };
      item.RecordNumber = ++CreatedItemsCount;
      item.IsSource = configData.SourceLibraries.Contains(item.Name);
      item.IsTarget = configData.TargetLibraries.Contains(item.Name);
      item.IsUsed = configData.UsedLibraries.Contains(item.Name);
      item.PropertyChanged += Item_PropertyChanged;
      if (item.IsTarget)
        targetLibraries.Remove(item.Name);
      this.Add(item);
    }       
    foreach (var name in targetLibraries)   
    {
      var item = new LibraryConfigViewModel { Name = name, IsTarget = true };
      item.RecordNumber = ++CreatedItemsCount;
      this.Add(item);
    }
    ValidateData();
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    //if (e.PropertyName == nameof(NamespaceConfigViewModel.Shortcut)
    //  || e.PropertyName == nameof(NamespaceConfigViewModel.TargetShortcut)
    //  || e.PropertyName == nameof(NamespaceConfigViewModel.TargetName))
      ValidateData();
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.SourceLibraries.Clear();
    configData.TargetLibraries.Clear();
    configData.UsedLibraries.Clear();
    foreach (var item in this)
    {
      if (item.IsSource)
        configData.SourceLibraries.Add(item.Name);
      if (item.IsTarget)
        configData.TargetLibraries.Add(item.Name);
      if (item.IsUsed)
        configData.UsedLibraries.Add(item.Name);
    }
  }

  public override bool ValidateData()
  {
    var ok = true;
    //if (!ValidateShortcuts())
    //  ok = false;
    //if (!ValidateTargetShortcuts())
    //  ok = false;
    //if (!ValidateUniqueTypes())
    //  ok = false;
    //NotifyPropertyChanged(nameof(AreAllShortcutsValid));
    //NotifyPropertyChanged(nameof(AreAllTargetShortcutsValid));
    //NotifyPropertyChanged(nameof(AreAllTypesUnique));
    return ok;
  }

}
