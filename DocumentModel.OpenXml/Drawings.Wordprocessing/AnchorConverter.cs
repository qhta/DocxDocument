namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromTop?.Value;
  }
  
  private static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromBottom?.Value;
  }
  
  private static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromLeft?.Value;
  }
  
  private static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromRight?.Value;
  }
  
  private static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  private static Boolean? GetSimplePos(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.SimplePos?.Value;
  }
  
  private static void SetSimplePos(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SimplePos = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SimplePos = null;
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  private static UInt32? GetRelativeHeight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement.RelativeHeight?.Value;
  }
  
  private static void SetRelativeHeight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.RelativeHeight = value;
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  private static Boolean? GetBehindDoc(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.BehindDoc?.Value;
  }
  
  private static void SetBehindDoc(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BehindDoc = null;
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  private static Boolean? GetLocked(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static void SetLocked(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  private static Boolean? GetLayoutInCell(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.LayoutInCell?.Value;
  }
  
  private static void SetLayoutInCell(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LayoutInCell = null;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  private static Boolean? GetHidden(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static void SetHidden(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static void SetAllowOverlap(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    if (openXmlElement.EditId?.Value != null)
      return UInt32.Parse(openXmlElement.EditId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetEditId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.EditId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.EditId = null;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAnchorId(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.Point2DType? GetSimplePosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSimplePosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.Point2DType? value)
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
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? GetHorizontalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.HorizontalPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHorizontalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.HorizontalPosition? value)
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
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.VerticalPosition? GetVerticalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.VerticalPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetVerticalPosition(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.VerticalPosition? value)
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
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.Extent? GetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.ExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.Extent? value)
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
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
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
  
  private static Boolean? GetWrapNone(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
    return itemElement != null;
  }
  
  private static void SetWrapNone(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.WrapSquare? GetWrapSquare(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapSquareConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWrapSquare(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapSquare? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.WrapTight? GetWrapTight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTightConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWrapTight(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTight? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.WrapThrough? GetWrapThrough(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapThroughConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWrapThrough(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapThrough? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.WrapTopBottom? GetWrapTopBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapTopBottomConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWrapTopBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTopBottom? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.DocProperties? GetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.DocProperties? value)
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
  
  private static DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? value)
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
  
  private static DocumentModel.Drawings.Graphic? GetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphic(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Drawings.Graphic? value)
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
  
  private static DocumentModel.Wordprocessing.Drawings.RelativeWidth? GetRelativeWidth(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Drawings.RelativeWidthConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelativeWidth(DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor openXmlElement, DocumentModel.Wordprocessing.Drawings.RelativeWidth? value)
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
