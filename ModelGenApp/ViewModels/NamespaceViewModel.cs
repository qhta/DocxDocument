namespace ModelGenApp.ViewModels;
public class NamespaceViewModel : ViewModel<Namespace>
{
  public NamespaceViewModel(PhaseViewModel phaseViewModel, Namespace ns, string? filter = null) : base(ns)
  {
    Phase = phaseViewModel;
    Filter = filter;
    Name = ns.OriginalName;
    if (phaseViewModel.PhaseNum == PPS.Rename)
      TargetName = ns.TargetName;
    AllTypes = new TypeListViewModel(phaseViewModel, this, "AllTypes", phaseViewModel.NameKindSelector, TKS.Any);
    Classes = new ClassListViewModel(phaseViewModel, this, "ClassTypes", phaseViewModel.NameKindSelector, TKS.Class, AllTypes);
    Enums = new EnumTypeListViewModel(phaseViewModel, this, "EnumTypes", phaseViewModel.NameKindSelector, TKS.Enum, AllTypes);
    Interfaces = new ClassListViewModel(phaseViewModel, this, "InterfaceTypes", phaseViewModel.NameKindSelector, TKS.Interface, AllTypes);
    Structs = new ClassListViewModel(phaseViewModel, this, "StructTypes", phaseViewModel.NameKindSelector, TKS.Struct, AllTypes);
    Others = new TypeListViewModel(phaseViewModel, this, "OtherTypes", phaseViewModel.NameKindSelector, TKS.Other, AllTypes);
  }

  public PhaseViewModel Phase { get; private set; }

  public string PhaseName => Phase.PhaseName;

  public string? Filter { get; private set; }

  //[DataGridColumn(
  //  HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_namespace),
  //  HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_namespace_tooltip)
  //  )]
  public string Name { get; set; }

  //[DataGridColumn(
  //  HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_namespace),
  //  HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_namespace_tooltip)
  //  )]
  public string? TargetName { get; set; }

  public string Caption => CommonStrings.ResourceManager.GetString(PhaseName, CultureInfo.CurrentUICulture) ?? PhaseName
                           + " " + CommonStrings.ResourceManager.GetString(Name, CultureInfo.CurrentUICulture) ?? Name;

  const int minColWith = 80;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.All),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "AllTypes.Count",
    ClipboardContentPath = "AllTypes.Count")]
  public TypeListViewModel AllTypes { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Classes),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Classes.Count",
    ClipboardContentPath = "Classes.Count")]
  public TypeListViewModel Classes { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Enums),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Enums.Count",
    ClipboardContentPath = "Enums.Count")]
  public TypeListViewModel Enums { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Interfaces),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Interfaces.Count",
    ClipboardContentPath = "Interfaces.Count")]
  public TypeListViewModel Interfaces { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Structs),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Structs.Count",
    ClipboardContentPath = "Structs.Count")]
  public TypeListViewModel Structs { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Others),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Others.Count",
    ClipboardContentPath = "Others.Count")]
  public TypeListViewModel Others { get; set; }

  public async void FillTypesAsync()
  {
    await Task.Run(() => FillTypes());
  }

  public void FillTypes()
  {
    AllTypes.FillItems();
    Classes.FillItems();
    Enums.FillItems();
    Interfaces.FillItems();
    Structs.FillItems();
    Others.FillItems();
  }

  public async void RefreshAsync()
  {
    await Task.Run(() => Refresh());
  }

  public void Refresh()
  {
    lock (Model.Types)
    {
      AllTypes.RefreshItemsAsync();
      Classes.RefreshItemsAsync();
      Enums.RefreshItemsAsync();
      Interfaces.RefreshItemsAsync();
      Structs.RefreshItemsAsync();
      Others.RefreshItemsAsync();
    }
  }

}
