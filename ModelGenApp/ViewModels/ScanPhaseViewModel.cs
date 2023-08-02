namespace ModelGenApp.ViewModels;

public class ScanPhaseViewModel: PhaseViewModel
{
  public ScanPhaseViewModel(string name): base (PPS.ScanTypes, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
  }

}
