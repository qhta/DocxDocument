using DocumentFormat.OpenXml.Office2013.WebExtension;

namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public static class WebExtensionBindingConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(WebExtensionBinding? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(WebExtensionBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   type, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetType(WebExtensionBinding? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }

  public static void SetType(WebExtensionBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }

  /// <summary>
  ///   appref, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetAppReference(WebExtensionBinding? openXmlElement)
  {
    return openXmlElement?.AppReference?.Value;
  }

  public static void SetAppReference(WebExtensionBinding? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AppReference = new StringValue { Value = value };
      else
        openXmlElement.AppReference = null;
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.OfficeArtExtensionList? GetOfficeArtExtensionList(WebExtensionBinding? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(WebExtensionBinding? openXmlElement, DocumentModel.WebExtensions.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.WebExtensions.WebExtensionBinding? CreateModelElement(WebExtensionBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionBinding();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.AppReference = GetAppReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionBinding? value)
    where OpenXmlElementType : WebExtensionBinding, new()
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