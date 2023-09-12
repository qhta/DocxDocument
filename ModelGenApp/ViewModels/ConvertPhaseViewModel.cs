namespace ModelGenApp.ViewModels;
public class ConvertPhaseViewModel : PhaseResultsViewModel
{
  public ConvertPhaseViewModel(string name) : base(PPS.ConvertTypes, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
    CanShowErrorDetails = true;
  }

  public override void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    var nspace = TypeManager.GetNamespace(typeInfoViewModel.Model.GetTargetNamespace());
    var name = typeInfoViewModel.Model.GetFullName(true, false, false);
    var filter = new TypeInfoViewModelFilter(TypeInfoKind.TypesWithSameName, name);
    var viewModel = new TypeListViewModel(this, 
      new NamespaceViewModel(this, nspace), TypeInfoKind.TypesWithSameName.ToString(), this.TypeNameSelector, TKS.Any, null);
    viewModel.IsInvalidMarkVisible = false;
    viewModel.FillItems();
    viewModel.Filter = filter;
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
