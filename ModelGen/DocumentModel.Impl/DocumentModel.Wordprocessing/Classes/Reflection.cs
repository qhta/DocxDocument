namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public class ReflectionImpl: ModelElementImpl, Reflection
{
  public DocumentFormat.OpenXml.Office2010.Word.Reflection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Reflection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? BlurRadius
  {
    get => (Int64?)OpenXmlElement?.BlurRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlurRadius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StartingOpacity
  {
    get => (Int32?)OpenXmlElement?.StartingOpacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartingOpacity = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StartPosition
  {
    get => (Int32?)OpenXmlElement?.StartPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StartPosition = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? EndingOpacity
  {
    get => (Int32?)OpenXmlElement?.EndingOpacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndingOpacity = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? EndPosition
  {
    get => (Int32?)OpenXmlElement?.EndPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EndPosition = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? DistanceFromText
  {
    get => (Int64?)OpenXmlElement?.DistanceFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromText = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? DirectionAngle
  {
    get => (Int32?)OpenXmlElement?.DirectionAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DirectionAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FadeDirection
  {
    get => (Int32?)OpenXmlElement?.FadeDirection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FadeDirection = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalScalingFactor
  {
    get => (Int32?)OpenXmlElement?.HorizontalScalingFactor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalScalingFactor = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalScalingFactor
  {
    get => (Int32?)OpenXmlElement?.VerticalScalingFactor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalScalingFactor = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? HorizontalSkewAngle
  {
    get => (Int32?)OpenXmlElement?.HorizontalSkewAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSkewAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? VerticalSkewAngle
  {
    get => (Int32?)OpenXmlElement?.VerticalSkewAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalSkewAngle = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues?)value;
    }
  }
  
}
