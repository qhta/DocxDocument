using System.Collections;

namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLPrefixMappings` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLPrefixMapping objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia"/>
public partial interface ICustomXMLPrefixMappings: IModelCollection<ICustomXMLPrefixMapping>
{
}

