
namespace DocumentModel.Interop.Core;

public interface PickerProperty: InteropObject
{
  string Id { get; }
  object Value { get; }
  MsoPickerField Type { get; }
}