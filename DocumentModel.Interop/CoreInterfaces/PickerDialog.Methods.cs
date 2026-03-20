
namespace DocumentModel.Interop.Core;

public partial interface PickerDialog
{
  public PickerResults CreatePickerResults();
  public PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  public PickerResults Resolve(string TokenText, int duplicateDlgMode);
}
