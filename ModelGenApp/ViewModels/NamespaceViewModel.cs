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
    Classes = new ClassListViewModel(phaseViewModel, this, "ClassTypes", phaseViewModel.NameKindSelector, TKS.Class);
    Enums = new EnumTypeListViewModel(phaseViewModel, this, "EnumTypes", phaseViewModel.NameKindSelector, TKS.Enum);
    Interfaces = new ClassListViewModel(phaseViewModel, this, "InterfaceTypes", phaseViewModel.NameKindSelector, TKS.Interface);
    Structs = new ClassListViewModel(phaseViewModel, this, "StructTypes", phaseViewModel.NameKindSelector, TKS.Struct);
    Others = new TypeListViewModel(phaseViewModel, this, "OtherTypes", phaseViewModel.NameKindSelector, TKS.Other);
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.All),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "AllTypes.Count",
    ClipboardContentPath = "AllTypes.Count")]
  public TypeListViewModel AllTypes { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Classes),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Classes.Count", 
    ClipboardContentPath = "Classes.Count")]
  public TypeListViewModel Classes { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Enums),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Enums.Count", 
    ClipboardContentPath = "Enums.Count")]
  public TypeListViewModel Enums { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Interfaces),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Interfaces.Count", 
    ClipboardContentPath = "Interfaces.Count")]
  public TypeListViewModel Interfaces { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Structs),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Structs.Count", 
    ClipboardContentPath = "Structs.Count")]
  public TypeListViewModel Structs { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Others),
    MinWidth = minColWith,
    DataTemplateResourceKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Others.Count", 
    ClipboardContentPath = "Others.Count")]
  public TypeListViewModel Others { get; set; }

  public async void LoadTypesAsync()
  {
    await Task.Run(() => LoadTypes());
  }

  public void LoadTypes()
  {
    var types = Model.Types.OrderBy(item => item.Name).ToList();
    var filter = Filter;
    if (filter != null)
    {
      if (filter == SummaryInfoKind.AcceptedTypes.ToString())
        types = types.Where(item => item.IsAcceptedAfter(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.RejectedTypes.ToString())
        types = types.Where(item => item.IsRejectedAfter(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.InvalidTypes.ToString())
        types = types.Where(item => !item.IsValid(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.RenamedTypes.ToString())
        types = types.Where(item => item.IsRenamed).ToList();
      if (filter == SummaryInfoKind.ConvertedTypes.ToString())
        types = types.Where(item => item.IsConverted).ToList();
    }
    //var subItems = types.Where(item=>item.Name=="Boolean").ToArray();
    //var count = subItems.Length;
    //if (count>0)
    //  Debug.Assert(true);
    AllTypes.CreateItems(types);
    Classes.FilterItems(AllTypes.Types);
    Enums.FilterItems(AllTypes.Types);
    Interfaces.FilterItems(AllTypes.Types);
    Structs.FilterItems(AllTypes.Types);
    Others.FilterItems(AllTypes.Types);
  }

}
