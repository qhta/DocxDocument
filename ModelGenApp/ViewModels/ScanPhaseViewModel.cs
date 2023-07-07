namespace ModelGenApp.ViewModels;
public class ScanPhaseViewModel: PhaseViewModel
{
  protected override async void ShowOverviewExecute()
  {
    await Task.Run(() =>
    {
      GetNamespaces(NTS.Origin | NTS.System);
    });
  }


}
