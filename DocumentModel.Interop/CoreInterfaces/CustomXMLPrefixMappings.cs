using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLPrefixMappings` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLPrefixMapping objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia
/// </remarks>
public partial interface CustomXMLPrefixMappings: InteropDictionary<string, CustomXMLPrefixMapping>
{
}
