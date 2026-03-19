
namespace DocumentModel.Interop.Core;

public interface _CustomXMLPartsEvents
{
  void PartAfterAdd(CustomXMLPart NewPart);
  void PartBeforeDelete(CustomXMLPart OldPart);
  void PartAfterLoad(CustomXMLPart Part);
}