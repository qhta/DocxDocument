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
  
  public WrapTopBottomImpl(): base() {}
  
  public WrapTopBottomImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Distance From Text on Top Edge
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
  /// Wrapping Boundaries.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.EffectExtent? EffectExtent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
