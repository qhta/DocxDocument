
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLPart` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlpart?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a single custom XML part in a CustomXMLParts collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlpart?view=office-pia"/>
public partial interface CustomXMLPart: _CustomXMLPart, _CustomXMLPartEvents_Event
{
}

