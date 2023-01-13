namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  public static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  public static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  public static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  public static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  public static Boolean? GetSimplePos(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.SimplePos?.Value;
  }
  
  public static void SetSimplePos(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SimplePos = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SimplePos = null;
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  public static UInt32? GetRelativeHeight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.RelativeHeight?.Value;
  }
  
  public static void SetRelativeHeight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeHeight = value;
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  public static Boolean? GetBehindDoc(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.BehindDoc?.Value;
  }
  
  public static void SetBehindDoc(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BehindDoc = null;
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  public static Boolean? GetLocked(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  public static void SetLocked(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  public static Boolean? GetLayoutInCell(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.LayoutInCell?.Value;
  }
  
  public static void SetLayoutInCell(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LayoutInCell = null;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  public static void SetAllowOverlap(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    if (openXmlElement?.EditId?.Value != null)
      return Convert.FromHexString(openXmlElement.EditId.Value);
    return null;
  }
  
  public static void SetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.EditId = Convert.ToHexString(value);
      else
        openXmlElement.EditId = null;
    }
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }
  
  public static void SetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AnchorId = Convert.ToHexString(value);
      else
        openXmlElement.AnchorId = null;
    }
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.Point2DType? GetSimplePosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSimplePosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? GetHorizontalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.HorizontalPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHorizontalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.HorizontalPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.HorizontalPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.VerticalPosition? GetVerticalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.VerticalPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVerticalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.VerticalPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.VerticalPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.Extent? GetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.ExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.Extent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.ExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetWrapNone(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetWrapNone(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapSquare? GetWrapSquare(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapSquareConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWrapSquare(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapSquare? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WrapSquareConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapTight? GetWrapTight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTightConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWrapTight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTight? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapThrough? GetWrapThrough(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapThroughConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWrapThrough(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapThrough? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WrapThroughConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapTopBottom? GetWrapTopBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTopBottomConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWrapTopBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTopBottom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTopBottomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.DocProperties? GetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.DocProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.DocPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Graphic? GetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Drawings.Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Drawings.RelativeWidth? GetRelativeWidth(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Drawings.RelativeWidthConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRelativeWidth(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement, DocumentModel.Wordprocessing.Drawings.RelativeWidth? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.Drawings.RelativeWidthConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.Anchor? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Anchor();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.SimplePos = GetSimplePos(openXmlElement);
      value.RelativeHeight = GetRelativeHeight(openXmlElement);
      value.BehindDoc = GetBehindDoc(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.LayoutInCell = GetLayoutInCell(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.AllowOverlap = GetAllowOverlap(openXmlElement);
      value.EditId = GetEditId(openXmlElement);
      value.AnchorId = GetAnchorId(openXmlElement);
      value.SimplePosition = GetSimplePosition(openXmlElement);
      value.HorizontalPosition = GetHorizontalPosition(openXmlElement);
      value.VerticalPosition = GetVerticalPosition(openXmlElement);
      value.Extent = GetExtent(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      value.WrapNone = GetWrapNone(openXmlElement);
      value.WrapSquare = GetWrapSquare(openXmlElement);
      value.WrapTight = GetWrapTight(openXmlElement);
      value.WrapThrough = GetWrapThrough(openXmlElement);
      value.WrapTopBottom = GetWrapTopBottom(openXmlElement);
      value.DocProperties = GetDocProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      value.RelativeWidth = GetRelativeWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Anchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
      SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetSimplePos(openXmlElement, value?.SimplePos);
      SetRelativeHeight(openXmlElement, value?.RelativeHeight);
      SetBehindDoc(openXmlElement, value?.BehindDoc);
      SetLocked(openXmlElement, value?.Locked);
      SetLayoutInCell(openXmlElement, value?.LayoutInCell);
      SetHidden(openXmlElement, value?.Hidden);
      SetAllowOverlap(openXmlElement, value?.AllowOverlap);
      SetEditId(openXmlElement, value?.EditId);
      SetAnchorId(openXmlElement, value?.AnchorId);
      SetSimplePosition(openXmlElement, value?.SimplePosition);
      SetHorizontalPosition(openXmlElement, value?.HorizontalPosition);
      SetVerticalPosition(openXmlElement, value?.VerticalPosition);
      SetExtent(openXmlElement, value?.Extent);
      SetEffectExtent(openXmlElement, value?.EffectExtent);
      SetWrapNone(openXmlElement, value?.WrapNone);
      SetWrapSquare(openXmlElement, value?.WrapSquare);
      SetWrapTight(openXmlElement, value?.WrapTight);
      SetWrapThrough(openXmlElement, value?.WrapThrough);
      SetWrapTopBottom(openXmlElement, value?.WrapTopBottom);
      SetDocProperties(openXmlElement, value?.DocProperties);
      SetNonVisualGraphicFrameDrawingProperties(openXmlElement, value?.NonVisualGraphicFrameDrawingProperties);
      SetGraphic(openXmlElement, value?.Graphic);
      SetRelativeWidth(openXmlElement, value?.RelativeWidth);
      return openXmlElement;
    }
    return default;
  }
}
