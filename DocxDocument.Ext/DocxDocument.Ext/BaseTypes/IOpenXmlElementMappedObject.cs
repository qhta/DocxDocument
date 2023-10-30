using DocumentFormat.OpenXml.Office2019.Excel.RichData2;

namespace DocumentModel;

public interface IOpenXmlElementMappedObject
{
  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement;
}
