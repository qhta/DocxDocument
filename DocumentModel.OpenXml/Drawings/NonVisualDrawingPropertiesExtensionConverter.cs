namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.CompatExtension? GetCompatExtension(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CompatExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCompatExtension(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.CompatExtension? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.BackgroundProperties? GetBackgroundProperties(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundProperties(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.BackgroundProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.CreationId? GetCreationId(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CreationIdConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCreationId(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.CreationId? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.PredecessorDrawingElementReference? GetPredecessorDrawingElementReference(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PredecessorDrawingElementReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPredecessorDrawingElementReference(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.PredecessorDrawingElementReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetDecorative(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Decorative>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDecorative(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ClassificationOutcome? GetClassificationOutcome(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ClassificationOutcomeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetClassificationOutcome(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.ClassificationOutcome? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.ScriptLink.ScriptLink? GetScriptLink(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.ScriptLink.ScriptLinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScriptLink(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? openXmlElement, DocumentModel.Drawings.Office.ScriptLink.ScriptLink? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
