
namespace DocumentModel.Interop.Core;

public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(CustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(CustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(CustomXMLPart Part);

public partial interface _CustomXMLPartsEvents_Event
{
}
