namespace ModelGenApp.ViewModels;

public class ScanPhaseViewModel: PhaseResultsViewModel
{
  public ScanPhaseViewModel(string name): base (PPS.ScanSource, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
  }

}
