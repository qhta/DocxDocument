namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public static class ThemeFamilyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVid(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return openXmlElement?.Vid?.Value;
  }
  
  private static void SetVid(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Vid = new StringValue { Value = value };
    else
      openXmlElement.Vid = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DM.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013Theme.ThemeFamily openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Theme.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMX.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013Theme.ThemeFamily openXmlElement, DM.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Theme.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013Theme.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.ThemeFamily? CreateModelElement(DXO2013Theme.ThemeFamily? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ThemeFamily();
      value.Name = GetName(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Vid = GetVid(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ThemeFamily? value)
    where OpenXmlElementType: DXO2013Theme.ThemeFamily, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetId(openXmlElement, value?.Id);
      SetVid(openXmlElement, value?.Vid);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
