namespace DocxDocument.Model;

public class DocxBasedElement<DocxElementType>: IDocxBasedElement where DocxElementType: OO.OpenXmlElement
{

  public DocxBasedElement(DocxElementType docxElement)
  {
    DocxElement = docxElement;
  }

  [XmlIgnore]
  public OO.OpenXmlElement OpenXmlElement
  {
    get => DocxElement; 
    set => DocxElement = (DocxElementType)value;
  }

  [XmlIgnore]
  public DocxElementType DocxElement { get; set; }
}