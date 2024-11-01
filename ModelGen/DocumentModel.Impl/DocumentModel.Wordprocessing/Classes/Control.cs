namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public partial class ControlImpl: ModelElementImpl, Control
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Control? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Control?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ControlImpl(): base() {}
  
  public ControlImpl(DocumentFormat.OpenXml.Wordprocessing.Control openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  public String? ShapeId
  {
    get => (System.String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
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
