using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerProperties: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  PickerProperty this[int Index] { get; }
  int Count { get; }
  PickerProperty Add(string Id, string Value, MsoPickerField Type);
  void Remove(string Id);
  new IEnumerator GetEnumerator();
}