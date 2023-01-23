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
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXW.CustomXmlElement openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// Gets or sets the element name.
  /// </summary>
  private static String? GetElement(DXW.CustomXmlElement openXmlElement)
  {
    return openXmlElement?.Element?.Value;
  }
  
  private static bool CmpElement(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Element?.Value == value;
  }
  
  private static void SetElement(DXW.CustomXmlElement openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Element = new StringValue { Value = value };
    else
      openXmlElement.Element = null;
  }
  
  /// <summary>
  /// Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  private static DMW.CustomXmlProperties? GetCustomXmlProperties(DXW.CustomXmlElement openXmlElement)
  {
    return DMXW.CustomXmlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlProperties>());
  }
  
  private static bool CmpCustomXmlProperties(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMW.CustomXmlElement? CreateModelElement(DXW.CustomXmlElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CustomXmlElement();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlElement? value)
    where OpenXmlElementType: DXW.CustomXmlElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetElement(openXmlElement, value?.Element);
      SetCustomXmlProperties(openXmlElement, value?.CustomXmlProperties);
      return openXmlElement;
    }
    return default;
  }
}
