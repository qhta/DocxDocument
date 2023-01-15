using DocumentFormat.OpenXml.Wordprocessing;
using Behaviors = DocumentModel.Wordprocessing.Behaviors;
using Category = DocumentModel.Wordprocessing.Category;
using DocPartName = DocumentModel.Wordprocessing.DocPartName;
using DocPartProperties = DocumentFormat.OpenXml.Wordprocessing.DocPartProperties;
using DocPartTypes = DocumentModel.Wordprocessing.DocPartTypes;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Glossary Document Entry Properties.
/// </summary>
public static class DocPartPropertiesConverter
{
  /// <summary>
  ///   Entry Name.
  /// </summary>
  public static DocPartName? GetDocPartName(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
    if (itemElement != null)
      return DocPartNameConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocPartName(DocPartProperties? openXmlElement, DocPartName? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartNameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartName>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Associated Paragraph Style Name.
  /// </summary>
  public static String? GetStyleId(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStyleId(DocPartProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StyleId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new StyleId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Entry Categorization.
  /// </summary>
  public static Category? GetCategory(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
    if (itemElement != null)
      return CategoryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategory(DocPartProperties? openXmlElement, Category? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Category>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Category>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Entry Types.
  /// </summary>
  public static DocPartTypes? GetDocPartTypes(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
    if (itemElement != null)
      return DocPartTypesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocPartTypes(DocPartProperties? openXmlElement, DocPartTypes? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartTypesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartTypes>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Entry Insertion Behaviors.
  /// </summary>
  public static Behaviors? GetBehaviors(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
    if (itemElement != null)
      return BehaviorsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBehaviors(DocPartProperties? openXmlElement, Behaviors? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behaviors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BehaviorsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Behaviors>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Description for Entry.
  /// </summary>
  public static String? GetDescription(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Description>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDescription(DocPartProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Description>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Description { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Entry ID.
  /// </summary>
  public static String? GetDocPartId(DocPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocPartId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDocPartId(DocPartProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocPartId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocPartProperties? CreateModelElement(DocPartProperties? openXmlElement)
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
    where OpenXmlElementType : DocPartProperties, new()
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