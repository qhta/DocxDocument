using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentModel.Drawings;
using DocumentModel.OpenXml.Wordprocessing.Drawings;
using DocumentModel.Wordprocessing.Drawings;
using Anchor = DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor;
using DocProperties = DocumentModel.Drawings.Wordprocessing.DocProperties;
using EffectExtent = DocumentModel.Drawings.Wordprocessing.EffectExtent;
using Extent = DocumentModel.Drawings.Wordprocessing.Extent;
using HorizontalPosition = DocumentModel.Drawings.Wordprocessing.HorizontalPosition;
using NonVisualGraphicFrameDrawingProperties = DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties;
using Point2DType = DocumentModel.Drawings.Wordprocessing.Point2DType;
using VerticalPosition = DocumentModel.Drawings.Wordprocessing.VerticalPosition;
using WrapSquare = DocumentModel.Drawings.Wordprocessing.WrapSquare;
using WrapThrough = DocumentModel.Drawings.Wordprocessing.WrapThrough;
using WrapTight = DocumentModel.Drawings.Wordprocessing.WrapTight;
using WrapTopBottom = DocumentModel.Drawings.Wordprocessing.WrapTopBottom;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Anchor for Floating DrawingML Object.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }

  public static void SetDistanceFromTop(Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }

  public static void SetDistanceFromBottom(Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }

  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }

  public static void SetDistanceFromLeft(Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }

  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(Anchor? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }

  public static void SetDistanceFromRight(Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }

  /// <summary>
  ///   Page Positioning
  /// </summary>
  public static Boolean? GetSimplePos(Anchor? openXmlElement)
  {
    return openXmlElement?.SimplePos?.Value;
  }

  public static void SetSimplePos(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SimplePos = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.SimplePos = null;
  }

  /// <summary>
  ///   Relative Z-Ordering Position
  /// </summary>
  public static UInt32? GetRelativeHeight(Anchor? openXmlElement)
  {
    return openXmlElement?.RelativeHeight?.Value;
  }

  public static void SetRelativeHeight(Anchor? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RelativeHeight = value;
  }

  /// <summary>
  ///   Display Behind Document Text
  /// </summary>
  public static Boolean? GetBehindDoc(Anchor? openXmlElement)
  {
    return openXmlElement?.BehindDoc?.Value;
  }

  public static void SetBehindDoc(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BehindDoc = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BehindDoc = null;
  }

  /// <summary>
  ///   Lock Anchor
  /// </summary>
  public static Boolean? GetLocked(Anchor? openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }

  public static void SetLocked(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Locked = null;
  }

  /// <summary>
  ///   Layout In Table Cell
  /// </summary>
  public static Boolean? GetLayoutInCell(Anchor? openXmlElement)
  {
    return openXmlElement?.LayoutInCell?.Value;
  }

  public static void SetLayoutInCell(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutInCell = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LayoutInCell = null;
  }

  /// <summary>
  ///   Hidden
  /// </summary>
  public static Boolean? GetHidden(Anchor? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }

  public static void SetHidden(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }

  /// <summary>
  ///   Allow Objects to Overlap
  /// </summary>
  public static Boolean? GetAllowOverlap(Anchor? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }

  public static void SetAllowOverlap(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AllowOverlap = null;
  }

  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetEditId(Anchor? openXmlElement)
  {
    if (openXmlElement?.EditId?.Value != null)
      return Convert.FromHexString(openXmlElement.EditId.Value);
    return null;
  }

  public static void SetEditId(Anchor? openXmlElement, Byte[]? value)
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
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(Anchor? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }

  public static void SetAnchorId(Anchor? openXmlElement, Byte[]? value)
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
  ///   Simple Positioning Coordinates.
  /// </summary>
  public static Point2DType? GetSimplePosition(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SimplePosition>();
    if (itemElement != null)
      return Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSimplePosition(Anchor? openXmlElement, Point2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SimplePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Point2DTypeConverter.CreateOpenXmlElement<SimplePosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Horizontal Positioning.
  /// </summary>
  public static HorizontalPosition? GetHorizontalPosition(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
    if (itemElement != null)
      return HorizontalPositionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHorizontalPosition(Anchor? openXmlElement, HorizontalPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HorizontalPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Vertical Positioning.
  /// </summary>
  public static VerticalPosition? GetVerticalPosition(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
    if (itemElement != null)
      return VerticalPositionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVerticalPosition(Anchor? openXmlElement, VerticalPosition? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VerticalPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Inline Drawing Object Extents.
  /// </summary>
  public static Extent? GetExtent(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
    if (itemElement != null)
      return ExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtent(Anchor? openXmlElement, Extent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EffectExtent.
  /// </summary>
  public static EffectExtent? GetEffectExtent(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectExtent(Anchor? openXmlElement, EffectExtent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetWrapNone(Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WrapNone>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWrapNone(Anchor? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WrapNone>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WrapNone();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static WrapSquare? GetWrapSquare(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
    if (itemElement != null)
      return WrapSquareConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWrapSquare(Anchor? openXmlElement, WrapSquare? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapSquareConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static WrapTight? GetWrapTight(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
    if (itemElement != null)
      return WrapTightConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWrapTight(Anchor? openXmlElement, WrapTight? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapTightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static WrapThrough? GetWrapThrough(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
    if (itemElement != null)
      return WrapThroughConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWrapThrough(Anchor? openXmlElement, WrapThrough? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapThroughConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static WrapTopBottom? GetWrapTopBottom(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
    if (itemElement != null)
      return WrapTopBottomConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWrapTopBottom(Anchor? openXmlElement, WrapTopBottom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WrapTopBottomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocProperties? GetDocProperties(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
    if (itemElement != null)
      return DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocProperties(Anchor? openXmlElement, DocProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGraphicFrameDrawingProperties(Anchor? openXmlElement, NonVisualGraphicFrameDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Graphic? GetGraphic(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return GraphicConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphic(Anchor? openXmlElement, Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelativeWidth? GetRelativeWidth(Anchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
    if (itemElement != null)
      return RelativeWidthConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRelativeWidth(Anchor? openXmlElement, RelativeWidth? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeWidthConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.Anchor? CreateModelElement(Anchor? openXmlElement)
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
    where OpenXmlElementType : Anchor, new()
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