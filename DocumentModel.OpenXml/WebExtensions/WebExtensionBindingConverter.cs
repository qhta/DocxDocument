namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public static class WebExtensionBindingConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetType(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static void SetType(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAppReference(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    return openXmlElement?.AppReference?.Value;
  }
  
  private static void SetAppReference(DXO2013WebExt.WebExtensionBinding openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AppReference = new StringValue { Value = value };
    else
      openXmlElement.AppReference = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWebExt.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013WebExt.WebExtensionBinding openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXWebExt.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013WebExt.WebExtensionBinding openXmlElement, DMWebExt.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013WebExt.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWebExt.WebExtensionBinding? CreateModelElement(DXO2013WebExt.WebExtensionBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionBinding();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.AppReference = GetAppReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionBinding? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionBinding, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetAppReference(openXmlElement, value?.AppReference);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
