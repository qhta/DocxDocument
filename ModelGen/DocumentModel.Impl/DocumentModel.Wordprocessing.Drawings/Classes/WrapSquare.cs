namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Square Wrapping.
/// </summary>
public class WrapSquareImpl: ModelElementImpl, WrapSquare
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WrapSquareImpl(): base() {}
  
  public WrapSquareImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.WrapTextKind? WrapText
  {
    get => (DocumentModel.Wordprocessing.Drawings.WrapTextKind?)OpenXmlElement?.WrapText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WrapText = (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public UInt32? DistanceFromTop
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromTop = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromBottom = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromLeft = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromRight = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.EffectExtent? EffectExtent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
