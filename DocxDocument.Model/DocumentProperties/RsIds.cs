namespace DocxDocument.Model;

public class Revisions: Collection<HexInt>, IRsIds
{
  [XmlAttribute]
  public HexInt? RsidRoot { get; set; }
}