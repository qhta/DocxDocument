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
  
  /// <summary>
  /// Shape Arc Width Radius
  /// </summary>
  public String? WidthRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  public String? HeightRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  public String? StartAngle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  public String? SwingAngle
  {
    get;
    set;
  }
  
}
