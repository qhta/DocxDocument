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
  
  public BlurImpl(): base() {}
  
  public BlurImpl(DocumentFormat.OpenXml.Drawing.Blur openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get => (System.Int64?)OpenXmlElement?.Radius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Radius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public Boolean? Grow
  {
    get => (System.Boolean?)OpenXmlElement?.Grow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Grow = (System.Boolean?)value;
    }
  }
  
}
