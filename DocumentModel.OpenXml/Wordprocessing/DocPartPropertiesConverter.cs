namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public static class DocPartPropertiesConverter
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  private static DMW.DocPartName? GetDocPartName(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocPartName>();
    if (itemElement != null)
      return DMXW.DocPartNameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartName(DXW.DocPartProperties openXmlElement, DMW.DocPartName? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocPartNameConverter.CreateOpenXmlElement<DXW.DocPartName>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  private static String? GetStyleId(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyleId(DXW.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StyleId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  private static DMW.Category? GetCategory(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Category>();
    if (itemElement != null)
      return DMXW.CategoryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategory(DXW.DocPartProperties openXmlElement, DMW.Category? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Category>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CategoryConverter.CreateOpenXmlElement<DXW.Category>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  private static DMW.DocPartTypes? GetDocPartTypes(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocPartTypes>();
    if (itemElement != null)
      return DMXW.DocPartTypesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartTypes(DXW.DocPartProperties openXmlElement, DMW.DocPartTypes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartTypes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocPartTypesConverter.CreateOpenXmlElement<DXW.DocPartTypes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  private static DMW.Behaviors? GetBehaviors(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Behaviors>();
    if (itemElement != null)
      return DMXW.BehaviorsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBehaviors(DXW.DocPartProperties openXmlElement, DMW.Behaviors? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Behaviors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BehaviorsConverter.CreateOpenXmlElement<DXW.Behaviors>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  private static String? GetDescription(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Description>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDescription(DXW.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Description>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Description { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  private static String? GetDocPartId(DXW.DocPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocPartId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartId(DXW.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DocPartProperties? CreateModelElement(DXW.DocPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocPartProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartProperties? value)
    where OpenXmlElementType: DXW.DocPartProperties, new()
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
