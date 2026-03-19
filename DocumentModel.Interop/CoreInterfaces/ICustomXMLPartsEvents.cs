
namespace DocumentModel.Interop.Core;

public interface ICustomXMLPartsEvents
{
  void PartAfterAdd(CustomXMLPart NewPart);
  void PartBeforeDelete(CustomXMLPart OldPart);
  void PartAfterLoad(CustomXMLPart Part);
}