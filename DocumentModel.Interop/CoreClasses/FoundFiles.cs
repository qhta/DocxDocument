using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the list of files returned from a file search.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.foundfiles?view=office-pia"/>
public partial class FoundFiles: InteropCollection<string>
{
}

