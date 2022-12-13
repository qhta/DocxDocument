namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public class RectangleImpl: ModelElementImpl, Rectangle
{
  public DocumentFormat.OpenXml.Drawing.Rectangle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Rectangle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RectangleImpl(): base() {}
  
  public RectangleImpl(DocumentFormat.OpenXml.Drawing.Rectangle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Left
  /// </summary>
  public String? Left
  {
    get => (System.String?)OpenXmlElement?.Left?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Left = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Top
  /// </summary>
  public String? Top
  {
    get => (System.String?)OpenXmlElement?.Top?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Top = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Right
  /// </summary>
  public String? Right
  {
    get => (System.String?)OpenXmlElement?.Right?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Right = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  public String? Bottom
  {
    get => (System.String?)OpenXmlElement?.Bottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bottom = (System.String?)value;
    }
  }
  
}
