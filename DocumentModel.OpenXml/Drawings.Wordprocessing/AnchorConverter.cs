namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromTop?.Value;
  }
  
  private static bool CmpDistanceFromTop(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromTop?.Value == value;
  }
  
  private static void SetDistanceFromTop(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromBottom?.Value;
  }
  
  private static bool CmpDistanceFromBottom(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromBottom?.Value == value;
  }
  
  private static void SetDistanceFromBottom(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromLeft?.Value == value;
  }
  
  private static void SetDistanceFromLeft(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromRight?.Value == value;
  }
  
  private static void SetDistanceFromRight(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  private static Boolean? GetSimplePos(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.SimplePos?.Value;
  }
  
  private static bool CmpSimplePos(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SimplePos?.Value == value;
  }
  
  private static void SetSimplePos(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SimplePos = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SimplePos = null;
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  private static UInt32? GetRelativeHeight(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.RelativeHeight?.Value;
  }
  
  private static bool CmpRelativeHeight(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.RelativeHeight?.Value == value;
  }
  
  private static void SetRelativeHeight(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.RelativeHeight = value;
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  private static Boolean? GetBehindDoc(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.BehindDoc?.Value;
  }
  
  private static bool CmpBehindDoc(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.BehindDoc?.Value == value;
  }
  
  private static void SetBehindDoc(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BehindDoc = null;
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  private static Boolean? GetLocked(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static bool CmpLocked(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Locked?.Value == value;
  }
  
  private static void SetLocked(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  private static Boolean? GetLayoutInCell(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.LayoutInCell?.Value;
  }
  
  private static bool CmpLayoutInCell(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LayoutInCell?.Value == value;
  }
  
  private static void SetLayoutInCell(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LayoutInCell = null;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  private static Boolean? GetHidden(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Hidden?.Value == value;
  }
  
  private static void SetHidden(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AllowOverlap?.Value == value;
  }
  
  private static void SetAllowOverlap(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetEditId(DXDrawW.Anchor openXmlElement)
  {
    if (openXmlElement.EditId?.Value != null)
      return UInt32.Parse(openXmlElement.EditId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpEditId(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.EditId?.Value != null)
      return UInt32.Parse(openXmlElement.EditId.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetEditId(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.EditId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.EditId = null;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DXDrawW.Anchor openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpAnchorId(DXDrawW.Anchor openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetAnchorId(DXDrawW.Anchor openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  private static DMDrawsW.Point2DType? GetSimplePosition(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.Point2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.SimplePosition>());
  }
  
  private static bool CmpSimplePosition(DXDrawW.Anchor openXmlElement, DMDrawsW.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.Point2DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.SimplePosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSimplePosition(DXDrawW.Anchor openXmlElement, DMDrawsW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.SimplePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.Point2DTypeConverter.CreateOpenXmlElement<DXDrawW.SimplePosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  private static DMDrawsW.HorizontalPosition? GetHorizontalPosition(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.HorizontalPositionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.HorizontalPosition>());
  }
  
  private static bool CmpHorizontalPosition(DXDrawW.Anchor openXmlElement, DMDrawsW.HorizontalPosition? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.HorizontalPositionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.HorizontalPosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHorizontalPosition(DXDrawW.Anchor openXmlElement, DMDrawsW.HorizontalPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.HorizontalPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.HorizontalPositionConverter.CreateOpenXmlElement<DXDrawW.HorizontalPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  private static DMDrawsW.VerticalPosition? GetVerticalPosition(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.VerticalPositionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.VerticalPosition>());
  }
  
  private static bool CmpVerticalPosition(DXDrawW.Anchor openXmlElement, DMDrawsW.VerticalPosition? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.VerticalPositionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.VerticalPosition>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalPosition(DXDrawW.Anchor openXmlElement, DMDrawsW.VerticalPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.VerticalPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.VerticalPositionConverter.CreateOpenXmlElement<DXDrawW.VerticalPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  private static DMDrawsW.Extent? GetExtent(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.ExtentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.Extent>());
  }
  
  private static bool CmpExtent(DXDrawW.Anchor openXmlElement, DMDrawsW.Extent? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.ExtentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.Extent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtent(DXDrawW.Anchor openXmlElement, DMDrawsW.Extent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.Extent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.ExtentConverter.CreateOpenXmlElement<DXDrawW.Extent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  private static DMDrawsW.EffectExtent? GetEffectExtent(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.EffectExtentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.EffectExtent>());
  }
  
  private static bool CmpEffectExtent(DXDrawW.Anchor openXmlElement, DMDrawsW.EffectExtent? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.EffectExtentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.EffectExtent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectExtent(DXDrawW.Anchor openXmlElement, DMDrawsW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.EffectExtentConverter.CreateOpenXmlElement<DXDrawW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetWrapNone(DXDrawW.Anchor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawW.WrapNone>() != null;
  }
  
  private static bool CmpWrapNone(DXDrawW.Anchor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawW.WrapNone>() != null == value;
  }
  
  private static void SetWrapNone(DXDrawW.Anchor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapNone>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawW.WrapNone();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.WrapSquare? GetWrapSquare(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.WrapSquareConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapSquare>());
  }
  
  private static bool CmpWrapSquare(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapSquare? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WrapSquareConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapSquare>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapSquare(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapSquare? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapSquare>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapSquareConverter.CreateOpenXmlElement<DXDrawW.WrapSquare>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.WrapTight? GetWrapTight(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.WrapTightConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapTight>());
  }
  
  private static bool CmpWrapTight(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapTight? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WrapTightConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapTight>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapTight(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapTight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapTight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapTightConverter.CreateOpenXmlElement<DXDrawW.WrapTight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.WrapThrough? GetWrapThrough(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.WrapThroughConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapThrough>());
  }
  
  private static bool CmpWrapThrough(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapThrough? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WrapThroughConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapThrough>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapThrough(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapThrough? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapThrough>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapThroughConverter.CreateOpenXmlElement<DXDrawW.WrapThrough>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.WrapTopBottom? GetWrapTopBottom(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.WrapTopBottomConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapTopBottom>());
  }
  
  private static bool CmpWrapTopBottom(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapTopBottom? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WrapTopBottomConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.WrapTopBottom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWrapTopBottom(DXDrawW.Anchor openXmlElement, DMDrawsW.WrapTopBottom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapTopBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapTopBottomConverter.CreateOpenXmlElement<DXDrawW.WrapTopBottom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.DocProperties? GetDocProperties(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.DocPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.DocProperties>());
  }
  
  private static bool CmpDocProperties(DXDrawW.Anchor openXmlElement, DMDrawsW.DocProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.DocPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.DocProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocProperties(DXDrawW.Anchor openXmlElement, DMDrawsW.DocProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.DocProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.DocPropertiesConverter.CreateOpenXmlElement<DXDrawW.DocProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDrawW.Anchor openXmlElement)
  {
    return DMXDrawsW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawW.NonVisualGraphicFrameDrawingProperties>());
  }
  
  private static bool CmpNonVisualGraphicFrameDrawingProperties(DXDrawW.Anchor openXmlElement, DMDrawsW.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.NonVisualGraphicFrameDrawingPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawW.NonVisualGraphicFrameDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDrawW.Anchor openXmlElement, DMDrawsW.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawW.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Graphic? GetGraphic(DXDrawW.Anchor openXmlElement)
  {
    return DMXDraws.GraphicConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Graphic>());
  }
  
  private static bool CmpGraphic(DXDrawW.Anchor openXmlElement, DMDraws.Graphic? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GraphicConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Graphic>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGraphic(DXDrawW.Anchor openXmlElement, DMDraws.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GraphicConverter.CreateOpenXmlElement<DXDraw.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWDraws.RelativeWidth? GetRelativeWidth(DXDrawW.Anchor openXmlElement)
  {
    return DMXWDraws.RelativeWidthConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010WDraw.RelativeWidth>());
  }
  
  private static bool CmpRelativeWidth(DXDrawW.Anchor openXmlElement, DMWDraws.RelativeWidth? value, DiffList? diffs, string? objName)
  {
    return DMXWDraws.RelativeWidthConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010WDraw.RelativeWidth>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRelativeWidth(DXDrawW.Anchor openXmlElement, DMWDraws.RelativeWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010WDraw.RelativeWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWDraws.RelativeWidthConverter.CreateOpenXmlElement<DXO2010WDraw.RelativeWidth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.Anchor? CreateModelElement(DXDrawW.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.Anchor();
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
  
  public static bool CompareModelElement(DXDrawW.Anchor? openXmlElement, DMDrawsW.Anchor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDistanceFromTop(openXmlElement, value.DistanceFromTop, diffs, objName))
        ok = false;
      if (!CmpDistanceFromBottom(openXmlElement, value.DistanceFromBottom, diffs, objName))
        ok = false;
      if (!CmpDistanceFromLeft(openXmlElement, value.DistanceFromLeft, diffs, objName))
        ok = false;
      if (!CmpDistanceFromRight(openXmlElement, value.DistanceFromRight, diffs, objName))
        ok = false;
      if (!CmpSimplePos(openXmlElement, value.SimplePos, diffs, objName))
        ok = false;
      if (!CmpRelativeHeight(openXmlElement, value.RelativeHeight, diffs, objName))
        ok = false;
      if (!CmpBehindDoc(openXmlElement, value.BehindDoc, diffs, objName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName))
        ok = false;
      if (!CmpLayoutInCell(openXmlElement, value.LayoutInCell, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpAllowOverlap(openXmlElement, value.AllowOverlap, diffs, objName))
        ok = false;
      if (!CmpEditId(openXmlElement, value.EditId, diffs, objName))
        ok = false;
      if (!CmpAnchorId(openXmlElement, value.AnchorId, diffs, objName))
        ok = false;
      if (!CmpSimplePosition(openXmlElement, value.SimplePosition, diffs, objName))
        ok = false;
      if (!CmpHorizontalPosition(openXmlElement, value.HorizontalPosition, diffs, objName))
        ok = false;
      if (!CmpVerticalPosition(openXmlElement, value.VerticalPosition, diffs, objName))
        ok = false;
      if (!CmpExtent(openXmlElement, value.Extent, diffs, objName))
        ok = false;
      if (!CmpEffectExtent(openXmlElement, value.EffectExtent, diffs, objName))
        ok = false;
      if (!CmpWrapNone(openXmlElement, value.WrapNone, diffs, objName))
        ok = false;
      if (!CmpWrapSquare(openXmlElement, value.WrapSquare, diffs, objName))
        ok = false;
      if (!CmpWrapTight(openXmlElement, value.WrapTight, diffs, objName))
        ok = false;
      if (!CmpWrapThrough(openXmlElement, value.WrapThrough, diffs, objName))
        ok = false;
      if (!CmpWrapTopBottom(openXmlElement, value.WrapTopBottom, diffs, objName))
        ok = false;
      if (!CmpDocProperties(openXmlElement, value.DocProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGraphicFrameDrawingProperties(openXmlElement, value.NonVisualGraphicFrameDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpGraphic(openXmlElement, value.Graphic, diffs, objName))
        ok = false;
      if (!CmpRelativeWidth(openXmlElement, value.RelativeWidth, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.Anchor? value)
    where OpenXmlElementType: DXDrawW.Anchor, new()
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
