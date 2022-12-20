namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public partial class WrapTopBottomImpl: ModelElementImpl, WrapTopBottom
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
  public DocumentModel.Drawings.Wordprocessing.EffectExtent? EffectExtent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.EffectExtentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.EffectExtentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
