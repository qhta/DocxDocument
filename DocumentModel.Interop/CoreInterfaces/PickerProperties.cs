using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia
/// </remarks>
public partial interface PickerProperties: InteropCollection<PickerProperty>
{
}
