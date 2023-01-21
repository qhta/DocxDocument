namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.CompatExtension? GetCompatExtension(DXDraw.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.CompatExtension>();
    if (itemElement != null)
      return DMXDraws.CompatExtensionConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Draw.BackgroundProperties>();
    if (itemElement != null)
      return DMXDraws.BackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016Draw.CreationId>();
    if (itemElement != null)
      return DMXDraws.CreationIdConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016Draw.PredecessorDrawingElementReference>();
    if (itemElement != null)
      return DMXDraws.PredecessorDrawingElementReferenceConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2019Draw.Decorative>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawDocCls.ClassificationOutcome>();
    if (itemElement != null)
      return DMXDraws.ClassificationOutcomeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXODrawY2021ScptLnk.ScriptLink>();
    if (itemElement != null)
      return DMXDrawsOScptLnk.ScriptLinkConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.NonVisualDrawingPropertiesExtension? CreateModelElement(DXDraw.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualDrawingPropertiesExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualDrawingPropertiesExtension? value)
    where OpenXmlElementType: DXDraw.NonVisualDrawingPropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetCompatExtension(openXmlElement, value?.CompatExtension);
      SetBackgroundProperties(openXmlElement, value?.BackgroundProperties);
      SetCreationId(openXmlElement, value?.CreationId);
      SetPredecessorDrawingElementReference(openXmlElement, value?.PredecessorDrawingElementReference);
      SetDecorative(openXmlElement, value?.Decorative);
      SetClassificationOutcome(openXmlElement, value?.ClassificationOutcome);
      SetScriptLink(openXmlElement, value?.ScriptLink);
      return openXmlElement;
    }
    return default;
  }
}
