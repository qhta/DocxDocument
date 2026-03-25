using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of `PickerResult` objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults?view=office-pia"/>
public partial interface PickerResults: InteropCollection<PickerResult>
{
}

