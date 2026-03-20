using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface PickerResults
{
  public PickerResult Add(string Id, string DisplayName, string Type, string SIPId, object ItemData, object SubItems);
}
