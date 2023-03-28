namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class converter from/to OpenXml.
///</summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.CompatExtension? GetCompatExtension(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.CompatExtension>();
    if (element != null)
      return DMXDraws.CompatExtensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCompatExtension(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.CompatExtension? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CompatExtensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.CompatExtension>(), value, diffs, objName);
  }
  
  private static void SetCompatExtension(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.CompatExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.CompatExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CompatExtensionConverter.CreateOpenXmlElement<DXO2010Draw.CompatExtension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BackgroundProperties? GetBackgroundProperties(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013Draw.BackgroundProperties>();
    if (element != null)
      return DMXDraws.BackgroundPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundProperties(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.BackgroundProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Draw.BackgroundProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundProperties(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.BackgroundProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Draw.BackgroundProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundPropertiesConverter.CreateOpenXmlElement<DXO2013Draw.BackgroundProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.CreationId? GetCreationId(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016Draw.CreationId>();
    if (element != null)
      return DMXDraws.CreationIdConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCreationId(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.CreationId? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CreationIdConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016Draw.CreationId>(), value, diffs, objName);
  }
  
  private static void SetCreationId(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.CreationId? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016Draw.CreationId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CreationIdConverter.CreateOpenXmlElement<DXO2016Draw.CreationId>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PredecessorDrawingElementReference? GetPredecessorDrawingElementReference(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016Draw.PredecessorDrawingElementReference>();
    if (element != null)
      return DMXDraws.PredecessorDrawingElementReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPredecessorDrawingElementReference(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.PredecessorDrawingElementReference? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PredecessorDrawingElementReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016Draw.PredecessorDrawingElementReference>(), value, diffs, objName);
  }
  
  private static void SetPredecessorDrawingElementReference(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.PredecessorDrawingElementReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016Draw.PredecessorDrawingElementReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PredecessorDrawingElementReferenceConverter.CreateOpenXmlElement<DXO2016Draw.PredecessorDrawingElementReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDecorative(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2019Draw.Decorative>() != null;
  }
  
  private static bool CmpDecorative(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2019Draw.Decorative>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2019Draw.Decorative", val, value);
    return false;
  }
  
  private static void SetDecorative(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2019Draw.Decorative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2019Draw.Decorative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ClassificationOutcome? GetClassificationOutcome(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawDocCls.ClassificationOutcome>();
    if (element != null)
      return DMXDraws.ClassificationOutcomeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClassificationOutcome(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.ClassificationOutcome? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ClassificationOutcomeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawDocCls.ClassificationOutcome>(), value, diffs, objName);
  }
  
  private static void SetClassificationOutcome(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.ClassificationOutcome? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawDocCls.ClassificationOutcome>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ClassificationOutcomeConverter.CreateOpenXmlElement<DXO2021DrawDocCls.ClassificationOutcome>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsOScptLnk.ScriptLink? GetScriptLink(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODrawY2021ScptLnk.ScriptLink>();
    if (element != null)
      return DMXDrawsOScptLnk.ScriptLinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScriptLink(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDrawsOScptLnk.ScriptLink? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsOScptLnk.ScriptLinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODrawY2021ScptLnk.ScriptLink>(), value, diffs, objName);
  }
  
  private static void SetScriptLink(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDrawsOScptLnk.ScriptLink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODrawY2021ScptLnk.ScriptLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsOScptLnk.ScriptLinkConverter.CreateOpenXmlElement<DXODrawY2021ScptLnk.ScriptLink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? CreateModelElement(DXDraw.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualDrawingPropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.CompatExtension = GetCompatExtension(openXmlElement);
      value.BackgroundProperties = GetBackgroundProperties(openXmlElement);
      value.CreationId = GetCreationId(openXmlElement);
      value.PredecessorDrawingElementReference = GetPredecessorDrawingElementReference(openXmlElement);
      value.Decorative = GetDecorative(openXmlElement);
      value.ClassificationOutcome = GetClassificationOutcome(openXmlElement);
      value.ScriptLink = GetScriptLink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualDrawingPropertiesExtension? openXmlElement, DMDraws.NonVisualDrawingPropertiesExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpCompatExtension(openXmlElement, value.CompatExtension, diffs, objName))
        ok = false;
      if (!CmpBackgroundProperties(openXmlElement, value.BackgroundProperties, diffs, objName))
        ok = false;
      if (!CmpCreationId(openXmlElement, value.CreationId, diffs, objName))
        ok = false;
      if (!CmpPredecessorDrawingElementReference(openXmlElement, value.PredecessorDrawingElementReference, diffs, objName))
        ok = false;
      if (!CmpDecorative(openXmlElement, value.Decorative, diffs, objName))
        ok = false;
      if (!CmpClassificationOutcome(openXmlElement, value.ClassificationOutcome, diffs, objName))
        ok = false;
      if (!CmpScriptLink(openXmlElement, value.ScriptLink, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualDrawingPropertiesExtension value)
    where OpenXmlElementType: DXDraw.NonVisualDrawingPropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, DMDraws.NonVisualDrawingPropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetCompatExtension(openXmlElement, value?.CompatExtension);
    SetBackgroundProperties(openXmlElement, value?.BackgroundProperties);
    SetCreationId(openXmlElement, value?.CreationId);
    SetPredecessorDrawingElementReference(openXmlElement, value?.PredecessorDrawingElementReference);
    SetDecorative(openXmlElement, value?.Decorative);
    SetClassificationOutcome(openXmlElement, value?.ClassificationOutcome);
    SetScriptLink(openXmlElement, value?.ScriptLink);
  }
}
