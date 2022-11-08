namespace DocxDocument.Model;

public class RsIds: Collection<HexInt>, IRsIds
{
  [XmlAttribute]
  public HexInt? RsidRoot { get; set; }
}