
namespace DocumentModel.Interop.Core;

public interface _CustomXMLPartsEvents
{
  public void PartAfterAdd(CustomXMLPart NewPart);
  public void PartBeforeDelete(CustomXMLPart OldPart);
  public void PartAfterLoad(CustomXMLPart Part);
}
