namespace ModelGenApp.ViewModels;

public class ScanPhaseViewModel: PhaseViewModel
{
  public ScanPhaseViewModel(string name): base (PPS.ScanSource, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
  }

}
