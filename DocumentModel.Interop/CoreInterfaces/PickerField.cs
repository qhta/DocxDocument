
namespace DocumentModel.Interop.Core;

public interface PickerField: InteropObject
{
  public string Name { get; }
  public MsoPickerField Type { get; }
  public bool IsHidden { get; }
}
