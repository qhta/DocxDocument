
namespace DocumentModel.Interfaces;

public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(CustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(CustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(CustomXMLPart Part);

/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia"/>
public partial interface _CustomXMLPartsEvents_Event
{
}

