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
    var element = openXmlElement?.GetFirstChild<DXW.DocPartName>();
    if (element != null)
      return DMXW.DocPartNameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocPartName(DXW.DocPartProperties openXmlElement, DMW.DocPartName? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DocPartNameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocPartName>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  private static String? GetStyleId(DXW.DocPartProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.StyleId>()?.Val?.Value;
  }
  
  private static bool CmpStyleId(DXW.DocPartProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "StyleId", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetStyleId(DXW.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.StyleId { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  private static DMW.Category? GetCategory(DXW.DocPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Category>();
    if (element != null)
      return DMXW.CategoryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategory(DXW.DocPartProperties openXmlElement, DMW.Category? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.CategoryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Category>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  private static DMW.DocPartTypes? GetDocPartTypes(DXW.DocPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocPartTypes>();
    if (element != null)
      return DMXW.DocPartTypesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocPartTypes(DXW.DocPartProperties openXmlElement, DMW.DocPartTypes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DocPartTypesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocPartTypes>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  private static DMW.Behaviors? GetBehaviors(DXW.DocPartProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Behaviors>();
    if (element != null)
      return DMXW.BehaviorsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBehaviors(DXW.DocPartProperties openXmlElement, DMW.Behaviors? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BehaviorsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Behaviors>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  private static String? GetDescription(DXW.DocPartProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Description>()?.Val?.Value;
  }
  
  private static bool CmpDescription(DXW.DocPartProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Description>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Description", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDescription(DXW.DocPartProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Description>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Description { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  private static String? GetDocPartId(DXW.DocPartProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DocPartId>()?.Val);
  }
  
  private static bool CmpDocPartId(DXW.DocPartProperties openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DocPartId>()?.Val, value, diffs, objName, "DocPartId");
  }
  
  private static void SetDocPartId(DXW.DocPartProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DocPartId>(openXmlElement, value);
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
  
  public static bool CompareModelElement(DXW.DocPartProperties? openXmlElement, DMW.DocPartProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocPartName(openXmlElement, value.DocPartName, diffs, objName, propName))
        ok = false;
      if (!CmpStyleId(openXmlElement, value.StyleId, diffs, objName, propName))
        ok = false;
      if (!CmpCategory(openXmlElement, value.Category, diffs, objName, propName))
        ok = false;
      if (!CmpDocPartTypes(openXmlElement, value.DocPartTypes, diffs, objName, propName))
        ok = false;
      if (!CmpBehaviors(openXmlElement, value.Behaviors, diffs, objName, propName))
        ok = false;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName, propName))
        ok = false;
      if (!CmpDocPartId(openXmlElement, value.DocPartId, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartProperties value)
    where OpenXmlElementType: DXW.DocPartProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocPartProperties openXmlElement, DMW.DocPartProperties value)
  {
    SetDocPartName(openXmlElement, value?.DocPartName);
    SetStyleId(openXmlElement, value?.StyleId);
    SetCategory(openXmlElement, value?.Category);
    SetDocPartTypes(openXmlElement, value?.DocPartTypes);
    SetBehaviors(openXmlElement, value?.Behaviors);
    SetDescription(openXmlElement, value?.Description);
    SetDocPartId(openXmlElement, value?.DocPartId);
  }
}
