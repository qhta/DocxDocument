namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public class WrapTopBottomImpl: ModelElementImpl, WrapTopBottom
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Distance From Text on Top Edge
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
  /// Wrapping Boundaries.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}
