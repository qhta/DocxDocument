
namespace DocumentModel.Interop.Core;

public interface PickerDialog: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string DataHandlerId { get; set; }
  string Title { get; set; }
  PickerProperties Properties { get; }
  PickerResults CreatePickerResults();
  PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  PickerResults Resolve(string TokenText, int duplicateDlgMode);
}