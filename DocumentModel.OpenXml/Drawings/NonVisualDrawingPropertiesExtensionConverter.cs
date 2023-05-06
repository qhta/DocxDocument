namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.NonVisualDrawingPropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.NonVisualDrawingPropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.CompatExtension? GetCompatExtension(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.CompatExtension>();
    if (element != null)
      return DMXD.CompatExtensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCompatExtension(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.CompatExtension? value, DiffList? diffs, string? objName)
  {
    return DMXD.CompatExtensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.CompatExtension>(), value, diffs, objName);
  }
  
  private static void SetCompatExtension(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.CompatExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.CompatExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CompatExtensionConverter.CreateOpenXmlElement<DXO10D.CompatExtension>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BackgroundProperties? GetBackgroundProperties(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13D.BackgroundProperties>();
    if (element != null)
      return DMXD.BackgroundPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundProperties(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.BackgroundProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13D.BackgroundProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundProperties(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.BackgroundProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13D.BackgroundProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundPropertiesConverter.CreateOpenXmlElement<DXO13D.BackgroundProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CreationId? GetCreationId(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16D.CreationId>();
    if (element != null)
      return DMXD.CreationIdConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCreationId(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.CreationId? value, DiffList? diffs, string? objName)
  {
    return DMXD.CreationIdConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16D.CreationId>(), value, diffs, objName);
  }
  
  private static void SetCreationId(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.CreationId? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16D.CreationId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CreationIdConverter.CreateOpenXmlElement<DXO16D.CreationId>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PredecessorDrawingElementReference? GetPredecessorDrawingElementReference(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16D.PredecessorDrawingElementReference>();
    if (element != null)
      return DMXD.PredecessorDrawingElementReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPredecessorDrawingElementReference(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.PredecessorDrawingElementReference? value, DiffList? diffs, string? objName)
  {
    return DMXD.PredecessorDrawingElementReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16D.PredecessorDrawingElementReference>(), value, diffs, objName);
  }
  
  private static void SetPredecessorDrawingElementReference(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.PredecessorDrawingElementReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16D.PredecessorDrawingElementReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PredecessorDrawingElementReferenceConverter.CreateOpenXmlElement<DXO16D.PredecessorDrawingElementReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetDecorative(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO19D.Decorative>() != null;
  }
  
  private static bool CmpDecorative(DXD.NonVisualDrawingPropertiesExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO19D.Decorative>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO19D.Decorative", val, value);
    return false;
  }
  
  private static void SetDecorative(DXD.NonVisualDrawingPropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO19D.Decorative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO19D.Decorative();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ClassificationOutcome? GetClassificationOutcome(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DDC.ClassificationOutcome>();
    if (element != null)
      return DMXD.ClassificationOutcomeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClassificationOutcome(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.ClassificationOutcome? value, DiffList? diffs, string? objName)
  {
    return DMXD.ClassificationOutcomeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DDC.ClassificationOutcome>(), value, diffs, objName);
  }
  
  private static void SetClassificationOutcome(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.ClassificationOutcome? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DDC.ClassificationOutcome>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ClassificationOutcomeConverter.CreateOpenXmlElement<DXO21DDC.ClassificationOutcome>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDOSL.ScriptLink? GetScriptLink(DXD.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODY21SL.ScriptLink>();
    if (element != null)
      return DMXDOScptLnk.ScriptLinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScriptLink(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMDOSL.ScriptLink? value, DiffList? diffs, string? objName)
  {
    return DMXDOScptLnk.ScriptLinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODY21SL.ScriptLink>(), value, diffs, objName);
  }
  
  private static void SetScriptLink(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMDOSL.ScriptLink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODY21SL.ScriptLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDOScptLnk.ScriptLinkConverter.CreateOpenXmlElement<DXODY21SL.ScriptLink>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? CreateModelElement(DXD.NonVisualDrawingPropertiesExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.NonVisualDrawingPropertiesExtension? openXmlElement, DMD.NonVisualDrawingPropertiesExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualDrawingPropertiesExtension value)
    where OpenXmlElementType: DXD.NonVisualDrawingPropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualDrawingPropertiesExtension openXmlElement, DMD.NonVisualDrawingPropertiesExtension value)
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
