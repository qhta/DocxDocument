namespace DocumentModel.Drawings;

/// <summary>
/// Reflection Effect.
/// </summary>
public partial class ReflectionImpl: ModelElementImpl, Reflection
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Reflection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Reflection?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ReflectionImpl(): base() {}
  
  public ReflectionImpl(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blur Radius
  /// </summary>
  public Int64? BlurRadius
  {
    get => (System.Int64?)OpenXmlElement?.BlurRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlurRadius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  public Int32? StartOpacity
  {
    get => (System.Int32?)OpenXmlElement?.StartOpacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartOpacity = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  public Int32? StartPosition
  {
    get => (System.Int32?)OpenXmlElement?.StartPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartPosition = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  public Int32? EndAlpha
  {
    get => (System.Int32?)OpenXmlElement?.EndAlpha?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndAlpha = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  public Int32? EndPosition
  {
    get => (System.Int32?)OpenXmlElement?.EndPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndPosition = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public Int64? Distance
  {
    get => (System.Int64?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public Int32? Direction
  {
    get => (System.Int32?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  public Int32? FadeDirection
  {
    get => (System.Int32?)OpenXmlElement?.FadeDirection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FadeDirection = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalRatio = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio
  {
    get => (System.Int32?)OpenXmlElement?.VerticalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalRatio = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalSkew?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSkew = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public Int32? VerticalSkew
  {
    get => (System.Int32?)OpenXmlElement?.VerticalSkew?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalSkew = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawings.RectangleAlignmentKind? Alignment
  {
    get => (DocumentModel.Drawings.RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape
  {
    get => (System.Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
}
