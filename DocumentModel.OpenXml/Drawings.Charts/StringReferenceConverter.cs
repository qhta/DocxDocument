namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  public static DocumentModel.Drawings.Charts.StringCache? GetStringCache(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStringCache(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement, DocumentModel.Drawings.Charts.StringCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.StringCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Charts.StrRefExtensionList? GetStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement, DocumentModel.Drawings.Charts.StrRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.StrRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StringReference? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringReference();
      value.Formula = GetFormula(openXmlElement);
      value.StringCache = GetStringCache(openXmlElement);
      value.StrRefExtensionList = GetStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetStringCache(openXmlElement, value?.StringCache);
      SetStrRefExtensionList(openXmlElement, value?.StrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
