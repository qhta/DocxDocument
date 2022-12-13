namespace DocumentModel.Drawings;

/// <summary>
/// Draw Arc To.
/// </summary>
public class ArcToImpl: ModelElementImpl, ArcTo
{
  public DocumentFormat.OpenXml.Drawing.ArcTo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ArcTo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArcToImpl(): base() {}
  
  public ArcToImpl(DocumentFormat.OpenXml.Drawing.ArcTo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shape Arc Width Radius
  /// </summary>
  public String? WidthRadius
  {
    get => (System.String?)OpenXmlElement?.WidthRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WidthRadius = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  public String? HeightRadius
  {
    get => (System.String?)OpenXmlElement?.HeightRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HeightRadius = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  public String? StartAngle
  {
    get => (System.String?)OpenXmlElement?.StartAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartAngle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  public String? SwingAngle
  {
    get => (System.String?)OpenXmlElement?.SwingAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SwingAngle = (System.String?)value;
    }
  }
  
}
