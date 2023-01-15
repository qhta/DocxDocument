using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentModel.Drawings;
using DocProperties = DocumentModel.Drawings.Wordprocessing.DocProperties;
using EffectExtent = DocumentModel.Drawings.Wordprocessing.EffectExtent;
using Extent = DocumentModel.Drawings.Wordprocessing.Extent;
using NonVisualGraphicFrameDrawingProperties = DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Inline DrawingML Object.
/// </summary>
public static class InlineConverter
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }

  public static void SetDistanceFromTop(Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }

  public static void SetDistanceFromBottom(Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }

  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }

  public static void SetDistanceFromLeft(Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }

  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(Inline? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }

  public static void SetDistanceFromRight(Inline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }

  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(Inline? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }

  public static void SetAnchorId(Inline? openXmlElement, Byte[]? value)
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
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetEditId(Inline? openXmlElement)
  {
    if (openXmlElement?.EditId?.Value != null)
      return Convert.FromHexString(openXmlElement.EditId.Value);
    return null;
  }

  public static void SetEditId(Inline? openXmlElement, Byte[]? value)
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
  ///   Drawing Object Size.
  /// </summary>
  public static Extent? GetExtent(Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
    if (itemElement != null)
      return ExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtent(Inline? openXmlElement, Extent? value)
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
  ///   Inline Wrapping Extent.
  /// </summary>
  public static EffectExtent? GetEffectExtent(Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectExtent(Inline? openXmlElement, EffectExtent? value)
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

  /// <summary>
  ///   Drawing Object Non-Visual Properties.
  /// </summary>
  public static DocProperties? GetDocProperties(Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
    if (itemElement != null)
      return DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocProperties(Inline? openXmlElement, DocProperties? value)
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

  /// <summary>
  ///   Common DrawingML Non-Visual Properties.
  /// </summary>
  public static NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGraphicFrameDrawingProperties(Inline? openXmlElement, NonVisualGraphicFrameDrawingProperties? value)
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

  /// <summary>
  ///   Graphic.
  /// </summary>
  public static Graphic? GetGraphic(Inline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return GraphicConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphic(Inline? openXmlElement, Graphic? value)
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

  public static DocumentModel.Drawings.Wordprocessing.Inline? CreateModelElement(Inline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.Inline();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.AnchorId = GetAnchorId(openXmlElement);
      value.EditId = GetEditId(openXmlElement);
      value.Extent = GetExtent(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      value.DocProperties = GetDocProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.Inline? value)
    where OpenXmlElementType : Inline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
      SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetAnchorId(openXmlElement, value?.AnchorId);
      SetEditId(openXmlElement, value?.EditId);
      SetExtent(openXmlElement, value?.Extent);
      SetEffectExtent(openXmlElement, value?.EffectExtent);
      SetDocProperties(openXmlElement, value?.DocProperties);
      SetNonVisualGraphicFrameDrawingProperties(openXmlElement, value?.NonVisualGraphicFrameDrawingProperties);
      SetGraphic(openXmlElement, value?.Graphic);
      return openXmlElement;
    }
    return default;
  }
}