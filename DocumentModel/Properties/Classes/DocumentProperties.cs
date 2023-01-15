namespace DocumentModel.Properties;

public partial class DocumentProperties
{
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }

  [XmlIgnore]
  public ExtendedProperties? ExtendedProperties { get; set; }

  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }
}