namespace DocxEd.ViewModels;

public class ScanPhaseViewModel: PhaseResultsViewModel
{
  public ScanPhaseViewModel(string name): base (PPS.ScanSource, name, NTS.Origin | NTS.System)
  { 
  }

}
