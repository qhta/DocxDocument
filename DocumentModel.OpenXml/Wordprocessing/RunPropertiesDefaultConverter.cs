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
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return DMXW.RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesDefault? value)
    where OpenXmlElementType: DXW.RunPropertiesDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunPropertiesBaseStyle(openXmlElement, value?.RunPropertiesBaseStyle);
      return openXmlElement;
    }
    return default;
  }
}
