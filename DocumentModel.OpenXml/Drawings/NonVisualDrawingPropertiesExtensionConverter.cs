namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.CompatExtension? GetCompatExtension(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CompatExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCompatExtension(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.CompatExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CompatExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.BackgroundProperties? GetBackgroundProperties(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundProperties(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.BackgroundProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BackgroundPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.CreationId? GetCreationId(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CreationIdConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCreationId(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.CreationId? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CreationIdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PredecessorDrawingElementReference? GetPredecessorDrawingElementReference(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PredecessorDrawingElementReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPredecessorDrawingElementReference(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.PredecessorDrawingElementReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PredecessorDrawingElementReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDecorative(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Decorative>();
    return itemElement != null;
  }
  
  private static void SetDecorative(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Decorative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2019.Drawing.Decorative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ClassificationOutcome? GetClassificationOutcome(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ClassificationOutcomeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetClassificationOutcome(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.ClassificationOutcome? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ClassificationOutcomeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Office.ScriptLink.ScriptLink? GetScriptLink(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ScriptLink.ScriptLinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScriptLink(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement, DocumentModel.Drawings.Office.ScriptLink.ScriptLink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Office.ScriptLink.ScriptLinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension, new()
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
