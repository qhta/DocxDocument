
namespace DocumentModel.Interop.Core;

public partial interface PickerDialog: InteropObject
{
  public string DataHandlerId { get; set; }
  public string Title { get; set; }
  public PickerProperties Properties { get; }
}
