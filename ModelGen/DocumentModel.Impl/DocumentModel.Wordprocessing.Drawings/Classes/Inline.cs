namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public class InlineImpl: ModelElementImpl, Inline
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public InlineImpl(): base() {}
  
  public InlineImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop
  {
    get => (UInt32?)OpenXmlElement?.DistanceFromTop?.Value;
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
    get => (UInt32?)OpenXmlElement?.DistanceFromBottom?.Value;
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
    get => (UInt32?)OpenXmlElement?.DistanceFromLeft?.Value;
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
    get => (UInt32?)OpenXmlElement?.DistanceFromRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromRight = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? AnchorId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? EditId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public Extent? Extent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public DocProperties? DocProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
