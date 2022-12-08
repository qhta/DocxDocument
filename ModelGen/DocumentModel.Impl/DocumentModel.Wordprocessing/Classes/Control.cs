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
  
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  public String? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
