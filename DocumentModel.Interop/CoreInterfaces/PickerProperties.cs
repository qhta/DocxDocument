using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerProperties: InteropObject, IEnumerable
{
  PickerProperty this[int Index] { get; }
  int Count { get; }
  PickerProperty Add(string Id, string Value, MsoPickerField Type);
  void Remove(string Id);
  new IEnumerator GetEnumerator();
}