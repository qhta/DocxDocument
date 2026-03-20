
namespace DocumentModel.Interop.Core;

public interface PickerProperty: InteropObject
{
  public string Id { get; }
  public object Value { get; }
  public MsoPickerField Type { get; }
}
