namespace DocxDocument.Model;

public class ListLevel: DocumentItem
{
  [XmlAttribute("Level")]
  [DefaultValue(0)]
  public int Level { get; set; }

  public ListType ListType
  {
    get
    {
      switch (NumberingFormat)
      {
        case NumberingFormat.None:
          return ListType.None;
        case NumberingFormat.Bullet:
          return ListType.Bulleted;
        default:
          return ListType.Numbered;
      }
    }
  }

  [XmlAttribute("Start")]
  [DefaultValue(0)]
  public int StartNumber { get; set; }

  [XmlAttribute("Restart")]
  [DefaultValue(0)]
  public int RestartLevel { get; set; }

  [XmlAttribute("Format")]
  public NumberingFormat NumberingFormat { get; set; }

  [XmlAttribute("Text")]
  public string? LevelText { get; set; }

  [XmlAttribute("UsageCount")]
  [DefaultValue(0)]
  public int UsageCount { get; set; }

}