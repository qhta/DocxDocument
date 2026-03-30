using System.Collections;

namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLNodes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnodes?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Contains a collection of CustomXMLNode objects that represent XML nodes in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnodes?view=office-pia"/>
public partial interface CustomXMLNodes: IModelCollection<CustomXMLNode>
{
}

