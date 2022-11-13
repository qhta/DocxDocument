namespace DocxDocument.Model;

public interface IDocxBasedElement<DocxElementType>: IDocxBasedElement where DocxElementType: OO.OpenXmlElement
{

  [XmlIgnore]
  public DocxElementType DocxElement { get; set; }
}