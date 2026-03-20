
namespace DocumentModel.Interop.Core;

public interface PickerDialog: InteropObject
{
  string DataHandlerId { get; set; }
  string Title { get; set; }
  PickerProperties Properties { get; }
  PickerResults CreatePickerResults();
  PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  PickerResults Resolve(string TokenText, int duplicateDlgMode);
}