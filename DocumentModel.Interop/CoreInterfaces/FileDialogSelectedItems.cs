using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of selected file or folder paths from a FileDialog.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems?view=office-pia
/// </remarks>
public partial interface FileDialogSelectedItems: InteropCollection<string>
{
}
