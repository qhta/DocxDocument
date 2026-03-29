using System.Collections;
using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// A collection of selected file or folder paths from a FileDialog.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems?view=office-pia"/>
public partial interface FileDialogSelectedItems: InteropValues<string>
{
}

