
namespace DocumentModel.Interop.Core;

public interface PickerField: InteropObject
{
  string Name { get; }
  MsoPickerField Type { get; }
  bool IsHidden { get; }
}