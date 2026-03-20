using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerResults` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerResults: InteropCollection<PickerResult>
{
}
