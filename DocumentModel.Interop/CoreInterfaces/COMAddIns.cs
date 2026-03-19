using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIns: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  COMAddIn Item(ref object Index);
  int Count { get; }
  new IEnumerator GetEnumerator();
  void Update();
  object Parent { get; }
  void SetAppModal(bool varfModal);
}