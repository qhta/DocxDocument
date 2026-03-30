
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLParts` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlparts?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLPart objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlparts?view=office-pia"/>
public partial interface ICustomXMLParts: I_CustomXMLParts, I_CustomXMLPartsEvents_Event
{
}

