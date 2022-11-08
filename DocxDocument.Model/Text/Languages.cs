namespace DocxDocument.Model;

public class Languages
{

  [XmlAttribute]
  public string? Latin { get; set;}

  [XmlAttribute]
  public string? ComplexScript { get; set; }

  [XmlAttribute]
  public string? EastAsia { get; set; }

  [XmlIgnore]
  [JsonIgnore]
  public string? Name
  {
    get => Latin ?? ComplexScript ?? EastAsia;
    set
    {
      Latin = value;
      ComplexScript = value;
      EastAsia = value;
    }
  }


  public bool HasSomeNameDifferent(string? aName)
  {
    if (Latin!=null && Latin!=aName)
      return true;
    if (ComplexScript != null && ComplexScript != aName)
      return true;
    if (EastAsia != null && EastAsia != aName)
      return true;
    return false;
  }

}