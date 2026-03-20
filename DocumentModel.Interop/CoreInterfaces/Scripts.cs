using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia
/// </remarks>
public partial interface Scripts: InteropDictionary<string, Script>
{
}
