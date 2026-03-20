using System.Collections;

namespace DocumentModel.Interop.Core;

public interface PickerProperties: InteropCollection<PickerProperty>
{

  PickerProperty Add(string Id, string Value, MsoPickerField Type);
  void Remove(string Id);
}