using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia
/// </remarks>
public partial interface _CustomXMLParts: InteropDictionary<string, CustomXMLPart>
{
}
