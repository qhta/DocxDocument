
namespace DocumentModel.Interop.Core;

public interface PickerDialog: InteropObject
{
  public string DataHandlerId { get; set; }
  public string Title { get; set; }
  public PickerProperties Properties { get; }
  public PickerResults CreatePickerResults();
  public PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  public PickerResults Resolve(string TokenText, int duplicateDlgMode);
}
