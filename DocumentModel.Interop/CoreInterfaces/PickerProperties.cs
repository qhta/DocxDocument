using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerProperties: InteropCollection<PickerProperty>
{

  public PickerProperty Add(string Id, string Value, MsoPickerField Type);
  public void Remove(string Id);
}
