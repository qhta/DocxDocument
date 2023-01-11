namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme.
/// </summary>
public static class ThemeConverter
{
  /// <summary>
  /// name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, String? value)
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
  public static String? GetThemeId(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    return openXmlElement?.ThemeId?.Value;
  }
  
  public static void SetThemeId(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ThemeId = new StringValue { Value = value };
      else
        openXmlElement.ThemeId = null;
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public static DocumentModel.Drawings.ThemeElements? GetThemeElements(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ThemeElementsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetThemeElements(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, DocumentModel.Drawings.ThemeElements? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ThemeElementsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ThemeElements>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public static DocumentModel.Drawings.ObjectDefaults? GetObjectDefaults(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ObjectDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetObjectDefaults(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, DocumentModel.Drawings.ObjectDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ObjectDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ObjectDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public static DocumentModel.Drawings.ExtraColorSchemeList? GetExtraColorSchemeList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtraColorSchemeListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtraColorSchemeList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, DocumentModel.Drawings.ExtraColorSchemeList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtraColorSchemeListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public static DocumentModel.Drawings.CustomColorList? GetCustomColorList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomColorList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, DocumentModel.Drawings.CustomColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.CustomColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.OfficeStyleSheetExtensionList? GetOfficeStyleSheetExtensionList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeStyleSheetExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeStyleSheetExtensionList(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement, DocumentModel.Drawings.OfficeStyleSheetExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.OfficeStyleSheetExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Theme? CreateModelElement(DocumentFormat.OpenXml.Drawing.Theme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Theme();
      value.Name = GetName(openXmlElement);
      value.ThemeId = GetThemeId(openXmlElement);
      value.ThemeElements = GetThemeElements(openXmlElement);
      value.ObjectDefaults = GetObjectDefaults(openXmlElement);
      value.ExtraColorSchemeList = GetExtraColorSchemeList(openXmlElement);
      value.CustomColorList = GetCustomColorList(openXmlElement);
      value.OfficeStyleSheetExtensionList = GetOfficeStyleSheetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Theme? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Theme, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
