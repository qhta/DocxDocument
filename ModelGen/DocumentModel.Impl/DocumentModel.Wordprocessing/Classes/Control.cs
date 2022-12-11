namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public class ControlImpl: ModelElementImpl, Control
{
  public DocumentFormat.OpenXml.Wordprocessing.Control? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Control?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => (String?)OpenXmlElement?.Name?.Value;
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
    get => (String?)OpenXmlElement?.ShapeId?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
