using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
