
namespace DocumentModel.CustomXml;

public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(ICustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(ICustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(ICustomXMLPart Part);

/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia"/>
public partial interface I_CustomXMLPartsEvents_Event
{
}

