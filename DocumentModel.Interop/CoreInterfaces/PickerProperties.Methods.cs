using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface PickerProperties
{
  public PickerProperty Add(string Id, string Value, MsoPickerField Type);
  public void Remove(string Id);
}
