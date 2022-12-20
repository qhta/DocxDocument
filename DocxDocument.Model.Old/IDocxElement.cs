namespace DocxDocument.Model;

public interface IDocxBasedElement
{
  public OO.OpenXmlElement OpenXmlElement { get; set; }
}