namespace ModelGenApp.ViewModels;
public class ConvertPhaseViewModel : PhaseViewModel
{
  public ConvertPhaseViewModel(string name) : base(PPS.ConvertTypes, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
  }

  protected override async void ShowResultsExecute()
  {
    WindowsManager.ShowWindow<PhaseResultsWindow>(this);
    if (NamespacesVM == null)
      await Task.Run(() => ShowOverviewExecute());
  }

  protected override async void ShowOverviewExecute()
  {
    await Task.Run(() =>
    {
      GetNamespaces();
    });
  }

}
