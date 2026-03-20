using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerProperties` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerProperties: InteropCollection<PickerProperty>
{
}
