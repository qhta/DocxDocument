namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  private static bool CmpDistanceFromTop(DXDW.Anchor openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromTop?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromTop", openXmlElement?.DistanceFromTop?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromTop(DXDW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  private static bool CmpDistanceFromBottom(DXDW.Anchor openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromBottom?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromBottom", openXmlElement?.DistanceFromBottom?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromBottom(DXDW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDW.Anchor openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromLeft?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromLeft", openXmlElement?.DistanceFromLeft?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromLeft(DXDW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDW.Anchor openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromRight?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromRight", openXmlElement?.DistanceFromRight?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromRight(DXDW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  private static Boolean? GetSimplePos(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.SimplePos?.Value;
  }
  
  private static bool CmpSimplePos(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SimplePos?.Value == value) return true;
    diffs?.Add(objName, "SimplePos", openXmlElement?.SimplePos?.Value, value);
    return false;
  }
  
  private static void SetSimplePos(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SimplePos = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SimplePos = null;
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  private static UInt32? GetRelativeHeight(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.RelativeHeight?.Value;
  }
  
  private static bool CmpRelativeHeight(DXDW.Anchor openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelativeHeight?.Value == value) return true;
    diffs?.Add(objName, "RelativeHeight", openXmlElement?.RelativeHeight?.Value, value);
    return false;
  }
  
  private static void SetRelativeHeight(DXDW.Anchor openXmlElement, UInt32? value)
  {
    openXmlElement.RelativeHeight = value;
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  private static Boolean? GetBehindDoc(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.BehindDoc?.Value;
  }
  
  private static bool CmpBehindDoc(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BehindDoc?.Value == value) return true;
    diffs?.Add(objName, "BehindDoc", openXmlElement?.BehindDoc?.Value, value);
    return false;
  }
  
  private static void SetBehindDoc(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BehindDoc = null;
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  private static Boolean? GetLocked(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static bool CmpLocked(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Locked?.Value == value) return true;
    diffs?.Add(objName, "Locked", openXmlElement?.Locked?.Value, value);
    return false;
  }
  
  private static void SetLocked(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  private static Boolean? GetLayoutInCell(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.LayoutInCell?.Value;
  }
  
  private static bool CmpLayoutInCell(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LayoutInCell?.Value == value) return true;
    diffs?.Add(objName, "LayoutInCell", openXmlElement?.LayoutInCell?.Value, value);
    return false;
  }
  
  private static void SetLayoutInCell(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LayoutInCell = null;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  private static Boolean? GetHidden(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static bool CmpHidden(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Hidden?.Value == value) return true;
    diffs?.Add(objName, "GlyphHidden", openXmlElement?.Hidden?.Value, value);
    return false;
  }
  
  private static void SetHidden(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXDW.Anchor openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetEditId(DXDW.Anchor openXmlElement)
  {
    if (openXmlElement?.EditId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.EditId.Value);
    return null;
  }
  
  private static bool CmpEditId(DXDW.Anchor openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.EditId?.Value, value, diffs, objName, "EditId");
  }
  
  private static void SetEditId(DXDW.Anchor openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.EditId = value.ToString();
    else
      openXmlElement.EditId = null;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetAnchorId(DXDW.Anchor openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AnchorId.Value);
    return null;
  }
  
  private static bool CmpAnchorId(DXDW.Anchor openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.AnchorId?.Value, value, diffs, objName, "AnchorId");
  }
  
  private static void SetAnchorId(DXDW.Anchor openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AnchorId = value.ToString();
    else
      openXmlElement.AnchorId = null;
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  private static DMDW.Point2DType? GetSimplePosition(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.SimplePosition>();
    if (element != null)
      return DMXDW.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSimplePosition(DXDW.Anchor openXmlElement, DMDW.Point2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.SimplePosition>(), value, diffs, objName, propName);
  }
  
  private static void SetSimplePosition(DXDW.Anchor openXmlElement, DMDW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.SimplePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.Point2DTypeConverter.CreateOpenXmlElement<DXDW.SimplePosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  private static DMDW.HorizontalPosition? GetHorizontalPosition(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.HorizontalPosition>();
    if (element != null)
      return DMXDW.HorizontalPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHorizontalPosition(DXDW.Anchor openXmlElement, DMDW.HorizontalPosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.HorizontalPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.HorizontalPosition>(), value, diffs, objName, propName);
  }
  
  private static void SetHorizontalPosition(DXDW.Anchor openXmlElement, DMDW.HorizontalPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.HorizontalPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.HorizontalPositionConverter.CreateOpenXmlElement<DXDW.HorizontalPosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  private static DMDW.VerticalPosition? GetVerticalPosition(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.VerticalPosition>();
    if (element != null)
      return DMXDW.VerticalPositionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVerticalPosition(DXDW.Anchor openXmlElement, DMDW.VerticalPosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.VerticalPositionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.VerticalPosition>(), value, diffs, objName, propName);
  }
  
  private static void SetVerticalPosition(DXDW.Anchor openXmlElement, DMDW.VerticalPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.VerticalPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.VerticalPositionConverter.CreateOpenXmlElement<DXDW.VerticalPosition>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  private static DMD.Extent? GetExtent(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.Extent>();
    if (element != null)
      return DMXDW.ExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtent(DXDW.Anchor openXmlElement, DMD.Extent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.ExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Extent>(), value, diffs, objName, propName);
  }
  
  private static void SetExtent(DXDW.Anchor openXmlElement, DMD.Extent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.Extent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.ExtentConverter.CreateOpenXmlElement<DXDW.Extent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  private static DMDW.EffectExtent? GetEffectExtent(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.EffectExtent>();
    if (element != null)
      return DMXDW.EffectExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectExtent(DXDW.Anchor openXmlElement, DMDW.EffectExtent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.EffectExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.EffectExtent>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectExtent(DXDW.Anchor openXmlElement, DMDW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.EffectExtentConverter.CreateOpenXmlElement<DXDW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetWrapNone(DXDW.Anchor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDW.WrapNone>() != null;
  }
  
  private static bool CmpWrapNone(DXDW.Anchor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDW.WrapNone>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDW.WrapNone", val, value);
    return false;
  }
  
  private static void SetWrapNone(DXDW.Anchor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDW.WrapNone>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDW.WrapNone();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.WrapSquare? GetWrapSquare(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapSquare>();
    if (element != null)
      return DMXDW.WrapSquareConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapSquare(DXDW.Anchor openXmlElement, DMDW.WrapSquare? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapSquareConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapSquare>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapSquare(DXDW.Anchor openXmlElement, DMDW.WrapSquare? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.WrapSquare>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WrapSquareConverter.CreateOpenXmlElement<DXDW.WrapSquare>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.WrapTight? GetWrapTight(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapTight>();
    if (element != null)
      return DMXDW.WrapTightConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapTight(DXDW.Anchor openXmlElement, DMDW.WrapTight? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapTightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapTight>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapTight(DXDW.Anchor openXmlElement, DMDW.WrapTight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.WrapTight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WrapTightConverter.CreateOpenXmlElement<DXDW.WrapTight>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.WrapThrough? GetWrapThrough(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapThrough>();
    if (element != null)
      return DMXDW.WrapThroughConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapThrough(DXDW.Anchor openXmlElement, DMDW.WrapThrough? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapThroughConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapThrough>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapThrough(DXDW.Anchor openXmlElement, DMDW.WrapThrough? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.WrapThrough>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WrapThroughConverter.CreateOpenXmlElement<DXDW.WrapThrough>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.WrapTopBottom? GetWrapTopBottom(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.WrapTopBottom>();
    if (element != null)
      return DMXDW.WrapTopBottomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWrapTopBottom(DXDW.Anchor openXmlElement, DMDW.WrapTopBottom? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WrapTopBottomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.WrapTopBottom>(), value, diffs, objName, propName);
  }
  
  private static void SetWrapTopBottom(DXDW.Anchor openXmlElement, DMDW.WrapTopBottom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.WrapTopBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WrapTopBottomConverter.CreateOpenXmlElement<DXDW.WrapTopBottom>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.DocProperties? GetDocProperties(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.DocProperties>();
    if (element != null)
      return DMXDW.DocPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocProperties(DXDW.Anchor openXmlElement, DMDW.DocProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.DocPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.DocProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetDocProperties(DXDW.Anchor openXmlElement, DMDW.DocProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.DocProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.DocPropertiesConverter.CreateOpenXmlElement<DXDW.DocProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
    if (element != null)
      return DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameDrawingProperties(DXDW.Anchor openXmlElement, DMDW.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDW.Anchor openXmlElement, DMDW.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDW.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Graphic? GetGraphic(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Graphic>();
    if (element != null)
      return DMXD.GraphicConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphic(DXDW.Anchor openXmlElement, DMD.Graphic? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GraphicConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Graphic>(), value, diffs, objName, propName);
  }
  
  private static void SetGraphic(DXDW.Anchor openXmlElement, DMD.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicConverter.CreateOpenXmlElement<DXD.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWD.RelativeWidth? GetRelativeWidth(DXDW.Anchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10WD.RelativeWidth>();
    if (element != null)
      return DMXWD.RelativeWidthConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRelativeWidth(DXDW.Anchor openXmlElement, DMWD.RelativeWidth? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWD.RelativeWidthConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10WD.RelativeWidth>(), value, diffs, objName, propName);
  }
  
  private static void SetRelativeWidth(DXDW.Anchor openXmlElement, DMWD.RelativeWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10WD.RelativeWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWD.RelativeWidthConverter.CreateOpenXmlElement<DXO10WD.RelativeWidth>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.Anchor? CreateModelElement(DXDW.Anchor? openXmlElement)
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
  
  public static bool CompareModelElement(DXDW.Anchor? openXmlElement, DMDW.Anchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDistanceFromTop(openXmlElement, value.DistanceFromTop, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromBottom(openXmlElement, value.DistanceFromBottom, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromLeft(openXmlElement, value.DistanceFromLeft, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromRight(openXmlElement, value.DistanceFromRight, diffs, objName, propName))
        ok = false;
      if (!CmpSimplePos(openXmlElement, value.SimplePos, diffs, objName, propName))
        ok = false;
      if (!CmpRelativeHeight(openXmlElement, value.RelativeHeight, diffs, objName, propName))
        ok = false;
      if (!CmpBehindDoc(openXmlElement, value.BehindDoc, diffs, objName, propName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName, propName))
        ok = false;
      if (!CmpLayoutInCell(openXmlElement, value.LayoutInCell, diffs, objName, propName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName, propName))
        ok = false;
      if (!CmpAllowOverlap(openXmlElement, value.AllowOverlap, diffs, objName, propName))
        ok = false;
      if (!CmpEditId(openXmlElement, value.EditId, diffs, objName, propName))
        ok = false;
      if (!CmpAnchorId(openXmlElement, value.AnchorId, diffs, objName, propName))
        ok = false;
      if (!CmpSimplePosition(openXmlElement, value.SimplePosition, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalPosition(openXmlElement, value.HorizontalPosition, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalPosition(openXmlElement, value.VerticalPosition, diffs, objName, propName))
        ok = false;
      if (!CmpExtent(openXmlElement, value.Extent, diffs, objName, propName))
        ok = false;
      if (!CmpEffectExtent(openXmlElement, value.EffectExtent, diffs, objName, propName))
        ok = false;
      if (!CmpWrapNone(openXmlElement, value.WrapNone, diffs, objName, propName))
        ok = false;
      if (!CmpWrapSquare(openXmlElement, value.WrapSquare, diffs, objName, propName))
        ok = false;
      if (!CmpWrapTight(openXmlElement, value.WrapTight, diffs, objName, propName))
        ok = false;
      if (!CmpWrapThrough(openXmlElement, value.WrapThrough, diffs, objName, propName))
        ok = false;
      if (!CmpWrapTopBottom(openXmlElement, value.WrapTopBottom, diffs, objName, propName))
        ok = false;
      if (!CmpDocProperties(openXmlElement, value.DocProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualGraphicFrameDrawingProperties(openXmlElement, value.NonVisualGraphicFrameDrawingProperties, diffs, objName, propName))
        ok = false;
      if (!CmpGraphic(openXmlElement, value.Graphic, diffs, objName, propName))
        ok = false;
      if (!CmpRelativeWidth(openXmlElement, value.RelativeWidth, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.Anchor value)
    where OpenXmlElementType: DXDW.Anchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.Anchor openXmlElement, DMDW.Anchor value)
  {
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
  }
}
