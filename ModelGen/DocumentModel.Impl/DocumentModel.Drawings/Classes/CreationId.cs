namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public partial class CreationIdImpl: ModelElementImpl, CreationId
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.CreationId? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.CreationId?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CreationIdImpl(): base() {}
  
  public CreationIdImpl(DocumentFormat.OpenXml.Office2016.Drawing.CreationId openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
