using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerFields: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  PickerField this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}