
namespace DocumentModel.Interop.Core;

public interface PickerDialog: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string DataHandlerId { get; set; }
  string Title { get; set; }
  PickerProperties Properties { get; }
  PickerResults CreatePickerResults();
  PickerResults Show(bool IsMultiSelect = true, PickerResults ExistingResults = null);
  PickerResults Resolve(string TokenText, int duplicateDlgMode);
}