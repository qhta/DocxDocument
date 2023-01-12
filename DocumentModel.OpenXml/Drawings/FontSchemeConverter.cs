namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public static class FontSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public static DocumentModel.Drawings.MajorFont? GetMajorFont(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MajorFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MajorFontConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMajorFont(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement, DocumentModel.Drawings.MajorFont? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MajorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.MajorFontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MajorFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public static DocumentModel.Drawings.MinorFont? GetMinorFont(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.MinorFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MinorFontConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMinorFont(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement, DocumentModel.Drawings.MinorFont? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MinorFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.MinorFontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.MinorFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.FontScheme? CreateModelElement(DocumentFormat.OpenXml.Drawing.FontScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FontScheme();
      value.Name = GetName(openXmlElement);
      value.MajorFont = GetMajorFont(openXmlElement);
      value.MinorFont = GetMinorFont(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FontScheme? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FontScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetMajorFont(openXmlElement, value?.MajorFont);
      SetMinorFont(openXmlElement, value?.MinorFont);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
