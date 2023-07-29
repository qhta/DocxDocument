namespace ModelGenApp.ViewModels;
public class RenamePhaseViewModel : PhaseViewModel
{
  public RenamePhaseViewModel(string name) : base(PPS.RenameTypes, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
    IsTargetNameVisible = true;
  }

  Window? window;
  protected override async void ShowResultsExecute()
  {
    if (window != null && window.IsVisible)
    {
      window.Topmost = true;
      window.Focus();
    }
    else
    {
      window = new PhaseResultsWindow();
      window.DataContext = this;
      window.Show();
      await Task.Run(() => ShowOverviewExecute());
    }
  }

  protected override async void ShowOverviewExecute()
  {
    await Task.Run(() =>
    {
      GetNamespaces();
    });
  }

  public override void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    var nspace = TypeManager.GetNamespace(typeInfoViewModel.Model.GetTargetNamespace());
    TNS tns = new TNS(false, true, false);
    var list = nspace.AcceptedTypes.Where(item=> item.GetTargetName() == typeInfoViewModel.Model.GetTargetName())
      .Select(item=>new TypeInfoViewModel(this, item, tns)).ToList();
    var viewModel = new TypeListViewModel(this, new NamespaceViewModel(this, nspace), "Types with duplicated names", tns,list);
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
