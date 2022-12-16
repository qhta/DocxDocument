namespace DocumentModel.Drawings.Wordprocessing;

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
  public DocumentModel.HexBinary? EditId
  {
    get
    {
      if (OpenXmlElement?.EditId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.EditId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.EditId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.EditId = null;
      }
    }
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinary? AnchorId
  {
    get
    {
      if (OpenXmlElement?.AnchorId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.AnchorId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.AnchorId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.AnchorId = null;
      }
    }
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Point2DType? SimplePosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.Point2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.HorizontalPosition? HorizontalPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.HorizontalPositionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.HorizontalPositionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.VerticalPosition? VerticalPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.VerticalPositionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.VerticalPositionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Extent? Extent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.ExtentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.ExtentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EffectExtent.
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
  
  public DocumentModel.Drawings.Wordprocessing.WrapSquare? WrapSquare
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WrapSquareImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WrapSquareImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.WrapTight? WrapTight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WrapTightImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WrapTightImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.WrapThrough? WrapThrough
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WrapThroughImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WrapThroughImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.WrapTopBottom? WrapTopBottom
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WrapTopBottomImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WrapTopBottomImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.DocProperties? DocProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.DocPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.DocPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.RelativeWidth? RelativeWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.RelativeWidthImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.RelativeWidthImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
