namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public class BlurImpl: ModelElementImpl, Blur
{
  public DocumentFormat.OpenXml.Drawing.Blur? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Blur?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public Boolean? Grow
  {
    get;
    set;
  }
  
}
