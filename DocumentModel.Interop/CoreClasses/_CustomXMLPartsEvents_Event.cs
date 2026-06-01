
namespace DocumentModel.Interop.Core;

public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(CustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(CustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(CustomXMLPart Part);

/// <summary>
/// Events class for CustomXMLParts object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia"/>
public partial class _CustomXMLPartsEvents_Event
{
}

