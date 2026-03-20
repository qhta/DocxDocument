
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLParts` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlparts?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLPart objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlparts?view=office-pia
/// </remarks>
public partial interface CustomXMLParts: _CustomXMLParts, _CustomXMLPartsEvents_Event
{
}
