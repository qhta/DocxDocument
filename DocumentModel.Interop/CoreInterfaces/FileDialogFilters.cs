using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of FileDialogFilter objects used by a FileDialog.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters?view=office-pia
/// </remarks>
public partial interface FileDialogFilters: InteropCollection<FileDialogFilter>
{
}
