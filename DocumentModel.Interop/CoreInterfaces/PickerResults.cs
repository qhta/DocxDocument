using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerResults: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  PickerResult this[int Index] { get; }
  int Count { get; }
  PickerResult Add(string Id, string DisplayName, string Type, string SIPId, object ItemData, object SubItems);
  new IEnumerator GetEnumerator();
}