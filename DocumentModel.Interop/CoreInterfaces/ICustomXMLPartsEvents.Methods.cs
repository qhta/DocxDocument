
namespace DocumentModel.Interop.Core;

public partial interface ICustomXMLPartsEvents
{
  public void PartAfterAdd(CustomXMLPart NewPart);
  public void PartBeforeDelete(CustomXMLPart OldPart);
  public void PartAfterLoad(CustomXMLPart Part);
}
