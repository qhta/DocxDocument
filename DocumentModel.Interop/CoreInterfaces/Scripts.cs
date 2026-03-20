using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Scripts` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Scripts: InteropDictionary<string, Script>
{
}
