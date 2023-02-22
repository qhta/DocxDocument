namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public static class CustomXmlElementConverter
{
  /// <summary>
  /// Gets or sets the custom XML Markup Namespace.
  /// </summary>
  private static String? GetUri(DXW.CustomXmlElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXW.CustomXmlElement openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  private static String? GetElement(DXW.CustomXmlElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Element);
  }
  
  private static bool CmpElement(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Element, value, diffs, objName, "Element");
  }
  
  private static void SetElement(DXW.CustomXmlElement openXmlElement, String? value)
  {
    openXmlElement.Element = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  private static DMW.CustomXmlProperties? GetCustomXmlProperties(DXW.CustomXmlElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlProperties>();
    if (element != null)
      return DMXW.CustomXmlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlProperties(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlProperties(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlPropertiesConverter.CreateOpenXmlElement<DXW.CustomXmlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlElement? CreateModelElement(DXW.CustomXmlElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlElement();
      value.Uri = GetUri(openXmlElement);
      value.Element = GetElement(openXmlElement);
      value.CustomXmlProperties = GetCustomXmlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CustomXmlElement? openXmlElement, DMW.CustomXmlElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpElement(openXmlElement, value.Element, diffs, objName))
        ok = false;
      if (!CmpCustomXmlProperties(openXmlElement, value.CustomXmlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlElement value)
    where OpenXmlElementType: DXW.CustomXmlElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlElement value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetElement(openXmlElement, value?.Element);
    SetCustomXmlProperties(openXmlElement, value?.CustomXmlProperties);
    }
  }
