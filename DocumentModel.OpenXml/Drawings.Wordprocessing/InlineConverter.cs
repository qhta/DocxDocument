namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public static class InlineConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDW.Inline openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  private static bool CmpDistanceFromTop(DXDW.Inline openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromTop?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromTop", openXmlElement?.DistanceFromTop?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromTop(DXDW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDW.Inline openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  private static bool CmpDistanceFromBottom(DXDW.Inline openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromBottom?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromBottom", openXmlElement?.DistanceFromBottom?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromBottom(DXDW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDW.Inline openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  private static bool CmpDistanceFromLeft(DXDW.Inline openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromLeft?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromLeft", openXmlElement?.DistanceFromLeft?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromLeft(DXDW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDW.Inline openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  private static bool CmpDistanceFromRight(DXDW.Inline openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DistanceFromRight?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromRight", openXmlElement?.DistanceFromRight?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromRight(DXDW.Inline openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetAnchorId(DXDW.Inline openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.AnchorId.Value);
    return null;
  }
  
  private static bool CmpAnchorId(DXDW.Inline openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.AnchorId?.Value, value, diffs, objName, "AnchorId");
  }
  
  private static void SetAnchorId(DXDW.Inline openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.AnchorId = value.ToString();
    else
      openXmlElement.AnchorId = null;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetEditId(DXDW.Inline openXmlElement)
  {
    if (openXmlElement?.EditId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.EditId.Value);
    return null;
  }
  
  private static bool CmpEditId(DXDW.Inline openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.EditId?.Value, value, diffs, objName, "EditId");
  }
  
  private static void SetEditId(DXDW.Inline openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.EditId = value.ToString();
    else
      openXmlElement.EditId = null;
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  private static DMD.Extent? GetExtent(DXDW.Inline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.Extent>();
    if (element != null)
      return DMXDW.ExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtent(DXDW.Inline openXmlElement, DMD.Extent? value, DiffList? diffs, string? objName)
  {
    return DMXDW.ExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.Extent>(), value, diffs, objName);
  }
  
  private static void SetExtent(DXDW.Inline openXmlElement, DMD.Extent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.Extent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.ExtentConverter.CreateOpenXmlElement<DXDW.Extent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  private static DMDW.EffectExtent? GetEffectExtent(DXDW.Inline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.EffectExtent>();
    if (element != null)
      return DMXDW.EffectExtentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectExtent(DXDW.Inline openXmlElement, DMDW.EffectExtent? value, DiffList? diffs, string? objName)
  {
    return DMXDW.EffectExtentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.EffectExtent>(), value, diffs, objName);
  }
  
  private static void SetEffectExtent(DXDW.Inline openXmlElement, DMDW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.EffectExtentConverter.CreateOpenXmlElement<DXDW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  private static DMDW.DocProperties? GetDocProperties(DXDW.Inline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.DocProperties>();
    if (element != null)
      return DMXDW.DocPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocProperties(DXDW.Inline openXmlElement, DMDW.DocProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDW.DocPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.DocProperties>(), value, diffs, objName);
  }
  
  private static void SetDocProperties(DXDW.Inline openXmlElement, DMDW.DocProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.DocProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.DocPropertiesConverter.CreateOpenXmlElement<DXDW.DocProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  private static DMDW.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDW.Inline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
    if (element != null)
      return DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameDrawingProperties(DXDW.Inline openXmlElement, DMDW.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDW.Inline openXmlElement, DMDW.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDW.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  private static DMD.Graphic? GetGraphic(DXDW.Inline openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Graphic>();
    if (element != null)
      return DMXD.GraphicConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphic(DXDW.Inline openXmlElement, DMD.Graphic? value, DiffList? diffs, string? objName)
  {
    return DMXD.GraphicConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Graphic>(), value, diffs, objName);
  }
  
  private static void SetGraphic(DXDW.Inline openXmlElement, DMD.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicConverter.CreateOpenXmlElement<DXD.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.Inline? CreateModelElement(DXDW.Inline? openXmlElement)
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
  
  public static bool CompareModelElement(DXDW.Inline? openXmlElement, DMDW.Inline? value, DiffList? diffs, string? objName)
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
      if (!CmpAnchorId(openXmlElement, value.AnchorId, diffs, objName))
        ok = false;
      if (!CmpEditId(openXmlElement, value.EditId, diffs, objName))
        ok = false;
      if (!CmpExtent(openXmlElement, value.Extent, diffs, objName))
        ok = false;
      if (!CmpEffectExtent(openXmlElement, value.EffectExtent, diffs, objName))
        ok = false;
      if (!CmpDocProperties(openXmlElement, value.DocProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGraphicFrameDrawingProperties(openXmlElement, value.NonVisualGraphicFrameDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpGraphic(openXmlElement, value.Graphic, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.Inline value)
    where OpenXmlElementType: DXDW.Inline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.Inline openXmlElement, DMDW.Inline value)
  {
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
  }
}
