using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of MsoFileType values used by FileSearch.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filetypes?view=office-pia
/// </remarks>
public partial interface FileTypes: InteropCollection<MsoFileType>
{
}
