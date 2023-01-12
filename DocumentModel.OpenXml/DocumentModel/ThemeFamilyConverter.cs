namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public static class ThemeFamilyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetVid(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement)
  {
    return openXmlElement?.Vid?.Value;
  }
  
  public static void SetVid(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Vid = new StringValue { Value = value };
      else
        openXmlElement.Vid = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement, DocumentModel.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.ThemeFamily? CreateModelElement(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ThemeFamily();
      value.Name = GetName(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Vid = GetVid(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ThemeFamily? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily, new()
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
