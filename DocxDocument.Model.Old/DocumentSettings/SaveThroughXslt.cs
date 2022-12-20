namespace DocxDocument.Model;

public class SaveThroughXslt: DocxBasedElement<WD.SaveThroughXslt>, ISaveThroughXslt
{

  public SaveThroughXslt(): base(new WD.SaveThroughXslt()){}

  public SaveThroughXslt(WD.SaveThroughXslt element) : base(element) { }


  [XmlAttribute]
  public string? Id
  {
    get => DocxRead.ReadString(DocxElement.Id);
    set => DocxElement.Id = value;
  }

  [XmlAttribute]
  public string? SolutionId
  {
    get => DocxRead.ReadString(DocxElement.SolutionId);
    set => DocxElement.SolutionId = value;
  }
}