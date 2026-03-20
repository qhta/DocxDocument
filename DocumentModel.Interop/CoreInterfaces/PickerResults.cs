using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerResults: InteropObject, IEnumerable
{
  PickerResult this[int Index] { get; }
  int Count { get; }
  PickerResult Add(string Id, string DisplayName, string Type, string SIPId, object ItemData, object SubItems);
  new IEnumerator GetEnumerator();
}