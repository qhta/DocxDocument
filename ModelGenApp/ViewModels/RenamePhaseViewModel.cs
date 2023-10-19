namespace ModelGenApp.ViewModels;
public class RenamePhaseViewModel : PhaseResultsViewModel
{
  public RenamePhaseViewModel(string name) : base(PPS.Rename, name, NTS.Origin | NTS.System)
  {
    CanShowErrorDetails = true;
  }

  public override void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    var nspace = TypeManager.GetNamespace(typeInfoViewModel.Model.GetTargetNamespace());
    var name = typeInfoViewModel.Model.GetFullName(true, false, false);
    var filter = new TypeInfoViewModelFilter(SummaryInfoKind.TypesWithSameName, name);
    var viewModel = new TypeListViewModel(this, null
      /*new NamespaceViewModel(this, nspace)*/, SummaryInfoKind.TypesWithSameName.ToString(), this.TypeNameSelector, TKS.Any, null);
    viewModel.IsInvalidMarkVisible = false;
    viewModel.FillItems();
    viewModel.Filter = filter;
    viewModel.ShowNamespaces = true;
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
