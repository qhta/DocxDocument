namespace DocxDocument.Model;

public struct SaveThroughXslt
{
  [XmlAttribute]
  public string Name { get; set; }

  [XmlAttribute]
  public string? SolutionId {get; set; }
}