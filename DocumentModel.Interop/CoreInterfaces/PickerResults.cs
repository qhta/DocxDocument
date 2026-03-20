using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerResults: InteropCollection<PickerResult>
{
  PickerResult Add(string Id, string DisplayName, string Type, string SIPId, object ItemData, object SubItems);
}