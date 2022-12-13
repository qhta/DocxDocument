namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public class AnchorImpl: ModelElementImpl, Anchor
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AnchorImpl(): base() {}
  
  public AnchorImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement): base(openXmlElement)
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
  /// Page Positioning
  /// </summary>
  public Boolean? SimplePos
  {
    get => (System.Boolean?)OpenXmlElement?.SimplePos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SimplePos = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  public UInt32? RelativeHeight
  {
    get => (System.UInt32?)OpenXmlElement?.RelativeHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeHeight = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  public Boolean? BehindDoc
  {
    get => (System.Boolean?)OpenXmlElement?.BehindDoc?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BehindDoc = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  public Boolean? Locked
  {
    get => (System.Boolean?)OpenXmlElement?.Locked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Locked = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  public Boolean? LayoutInCell
  {
    get => (System.Boolean?)OpenXmlElement?.LayoutInCell?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutInCell = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public Boolean? Hidden
  {
    get => (System.Boolean?)OpenXmlElement?.Hidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get => (System.Boolean?)OpenXmlElement?.AllowOverlap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowOverlap = (System.Boolean?)value;
    }
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
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? AnchorId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Point2DType? SimplePosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.HorizontalPosition? HorizontalPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.VerticalPosition? VerticalPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Extent? Extent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.EffectExtent? EffectExtent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? WrapNone
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Drawings.WrapSquare? WrapSquare
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.WrapTight? WrapTight
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.WrapThrough? WrapThrough
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.WrapTopBottom? WrapTopBottom
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.DocProperties? DocProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Drawings.RelativeWidth? RelativeWidth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
