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
  
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextKind? WrapText
  {
    get => (WrapTextKind?)OpenXmlElement?.WrapText?.Value;
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
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}
