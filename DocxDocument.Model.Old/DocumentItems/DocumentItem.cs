namespace DocxDocument.Model;

public abstract class DocumentItem
{
  [XmlAttribute("Id")]
  public int ID { get; set; }

  [XmlIgnore]
  [JsonIgnore]
  public Document? Document { get; set; }
}