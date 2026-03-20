using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerFields: InteropObject, IEnumerable
{
  PickerField this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}