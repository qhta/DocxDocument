namespace DocumentModel.Properties;

public partial class DocumentProperties
{
  [XmlIgnore]
  public DocumentModel.Properties.CoreProperties? CoreProperties { get; set; }
  [XmlIgnore]
  public DocumentModel.Properties.ExtendedProperties? ExtendedProperties { get; set; }
  [XmlIgnore]
  public DocumentModel.Properties.CustomProperties? CustomProperties { get; set; }

}