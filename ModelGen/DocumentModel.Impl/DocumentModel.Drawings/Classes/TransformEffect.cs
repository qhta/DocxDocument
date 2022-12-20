namespace DocumentModel.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public partial class TransformEffectImpl: ModelElementImpl, TransformEffect
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.TransformEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TransformEffect?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TransformEffectImpl(): base() {}
  
  public TransformEffectImpl(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// Horizontal Shift
  /// </summary>
  public Int64? HorizontalShift
  {
    get => (System.Int64?)OpenXmlElement?.HorizontalShift?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalShift = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  public Int64? VerticalShift
  {
    get => (System.Int64?)OpenXmlElement?.VerticalShift?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalShift = (System.Int64?)value;
    }
  }
  
}
