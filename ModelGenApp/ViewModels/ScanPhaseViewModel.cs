namespace ModelGenApp.ViewModels;
public class ScanPhaseViewModel: PhaseViewModel
{
  public ScanPhaseViewModel(string name): base (PPS.ScanTypes, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
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

}
