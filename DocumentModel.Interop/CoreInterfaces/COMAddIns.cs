using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIns: InteropCollection<COMAddIn>
{
  COMAddIn Item(ref object Index);
  void Update();
  void SetAppModal(bool varfModal);
}