namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public static class InlineConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDrawW.Inline openXmlElement)
  {
    return openXmlElement.DistanceFromTop?.Value;
  }
  
  private static void SetDistanceFromTop(DXDrawW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDrawW.Inline openXmlElement)
  {
    return openXmlElement.DistanceFromBottom?.Value;
  }
  
  private static void SetDistanceFromBottom(DXDrawW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDrawW.Inline openXmlElement)
  {
    return openXmlElement.DistanceFromLeft?.Value;
  }
  
  private static void SetDistanceFromLeft(DXDrawW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDrawW.Inline openXmlElement)
  {
    return openXmlElement.DistanceFromRight?.Value;
  }
  
  private static void SetDistanceFromRight(DXDrawW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DXDrawW.Inline openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAnchorId(DXDrawW.Inline openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetEditId(DXDrawW.Inline openXmlElement)
  {
    if (openXmlElement.EditId?.Value != null)
      return UInt32.Parse(openXmlElement.EditId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetEditId(DXDrawW.Inline openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.EditId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.EditId = null;
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  private static DMDrawsW.Extent? GetExtent(DXDrawW.Inline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.Extent>();
    if (itemElement != null)
      return DMXDrawsW.ExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtent(DXDrawW.Inline openXmlElement, DMDrawsW.Extent? value)
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
  /// Inline Wrapping Extent.
  /// </summary>
  private static DMDrawsW.EffectExtent? GetEffectExtent(DXDrawW.Inline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.EffectExtent>();
    if (itemElement != null)
      return DMXDrawsW.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectExtent(DXDrawW.Inline openXmlElement, DMDrawsW.EffectExtent? value)
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
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  private static DMDrawsW.DocProperties? GetDocProperties(DXDrawW.Inline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.DocProperties>();
    if (itemElement != null)
      return DMXDrawsW.DocPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocProperties(DXDrawW.Inline openXmlElement, DMDrawsW.DocProperties? value)
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
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  private static DMDrawsW.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDrawW.Inline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDrawW.Inline openXmlElement, DMDrawsW.NonVisualGraphicFrameDrawingProperties? value)
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
  
  /// <summary>
  /// Graphic.
  /// </summary>
  private static DMDraws.Graphic? GetGraphic(DXDrawW.Inline openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      return DMXDraws.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphic(DXDrawW.Inline openXmlElement, DMDraws.Graphic? value)
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
  
  public static DMDrawsW.Inline? CreateModelElement(DXDrawW.Inline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.Inline();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.Inline? value)
    where OpenXmlElementType: DXDrawW.Inline, new()
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
