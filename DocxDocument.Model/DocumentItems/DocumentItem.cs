namespace DocxDocument.Model;

public abstract class DocumentItem
{
  [XmlAttribute("ID")]
  public int ID { get; set; }

  [XmlIgnore]
  [JsonIgnore]
  public Document? Document { get; set; }
}