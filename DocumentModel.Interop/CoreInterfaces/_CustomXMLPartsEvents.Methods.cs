
namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLPartsEvents
{
  public void PartAfterAdd(CustomXMLPart NewPart);
  public void PartBeforeDelete(CustomXMLPart OldPart);
  public void PartAfterLoad(CustomXMLPart Part);
}
