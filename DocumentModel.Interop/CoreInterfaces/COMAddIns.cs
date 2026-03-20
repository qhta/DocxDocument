using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIns: InteropCollection<COMAddIn>
{
  public COMAddIn Item(ref object Index);
  public void Update();
  public void SetAppModal(bool varfModal);
}
