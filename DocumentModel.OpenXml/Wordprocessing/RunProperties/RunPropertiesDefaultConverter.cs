namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public static class RunPropertiesDefaultConverter
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  private static DMW.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
      return DMXW.RunPropertiesBaseStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesBaseStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesBaseStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>(), value, diffs, objName);
  }
  
  private static void SetRunPropertiesBaseStyle(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesBaseStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.RunPropertiesBaseStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.RunPropertiesDefault? CreateModelElement(DXW.RunPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunPropertiesDefault();
      value.RunPropertiesBaseStyle = GetRunPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RunPropertiesDefault? openXmlElement, DMW.RunPropertiesDefault? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunPropertiesBaseStyle(openXmlElement, value.RunPropertiesBaseStyle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesDefault value)
    where OpenXmlElementType: DXW.RunPropertiesDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RunPropertiesDefault openXmlElement, DMW.RunPropertiesDefault value)
  {
    SetRunPropertiesBaseStyle(openXmlElement, value?.RunPropertiesBaseStyle);
  }
}
