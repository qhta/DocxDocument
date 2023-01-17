namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public static class DocPartPropertiesConverter
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocPartName? GetDocPartName(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocPartNameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartName(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, DocumentModel.Wordprocessing.DocPartName? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocPartNameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartName>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  private static String? GetStyleId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyleId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.StyleId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  private static DocumentModel.Wordprocessing.Category? GetCategory(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CategoryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategory(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, DocumentModel.Wordprocessing.Category? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.CategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Category>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocPartTypes? GetDocPartTypes(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocPartTypesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartTypes(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, DocumentModel.Wordprocessing.DocPartTypes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocPartTypesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  private static DocumentModel.Wordprocessing.Behaviors? GetBehaviors(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BehaviorsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBehaviors(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, DocumentModel.Wordprocessing.Behaviors? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BehaviorsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Behaviors>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  private static String? GetDescription(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Description>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDescription(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Description>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Description { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  private static String? GetDocPartId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartId(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.DocPartProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPartProperties();
      value.DocPartName = GetDocPartName(openXmlElement);
      value.StyleId = GetStyleId(openXmlElement);
      value.Category = GetCategory(openXmlElement);
      value.DocPartTypes = GetDocPartTypes(openXmlElement);
      value.Behaviors = GetBehaviors(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.DocPartId = GetDocPartId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocPartProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocPartProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartName(openXmlElement, value?.DocPartName);
      SetStyleId(openXmlElement, value?.StyleId);
      SetCategory(openXmlElement, value?.Category);
      SetDocPartTypes(openXmlElement, value?.DocPartTypes);
      SetBehaviors(openXmlElement, value?.Behaviors);
      SetDescription(openXmlElement, value?.Description);
      SetDocPartId(openXmlElement, value?.DocPartId);
      return openXmlElement;
    }
    return default;
  }
}
