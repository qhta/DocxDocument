using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIns: InteropObject, IEnumerable
{
  COMAddIn Item(ref object Index);
  int Count { get; }
  new IEnumerator GetEnumerator();
  void Update();
  void SetAppModal(bool varfModal);
}