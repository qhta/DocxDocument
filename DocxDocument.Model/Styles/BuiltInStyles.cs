namespace DocxDocument.Model;

public class BuiltInStyles: Collection<Style>
{
  [XmlAttribute]
  public int? InitCount { get; set; }

  [XmlAttribute]
  public bool? DefaultLockedState {get; set;}

  [XmlAttribute]
  public bool? DefaultPrimaryStyle { get; set; }

  [XmlAttribute]
  public bool? DefaultSemiHidden { get; set; }

  [XmlAttribute]
  public bool? DefaultUnhideWhenUsed { get; set; }

  [XmlAttribute]
  public int? DefaultUiPriority { get; set; }


}