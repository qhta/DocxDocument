using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of MsoFileType values used by FileSearch.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filetypes?view=office-pia"/>
public partial interface FileTypes: InteropCollection<MsoFileType>
{
}

