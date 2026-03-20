
namespace DocumentModel.Interop.Core;

public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(CustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(CustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(CustomXMLPart Part);

/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia
/// </remarks>
public partial interface _CustomXMLPartsEvents_Event
{
}
