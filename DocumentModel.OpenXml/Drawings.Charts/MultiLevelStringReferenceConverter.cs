namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public static class MultiLevelStringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MultiLevelStringCache? GetMultiLevelStringCache(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MultiLevelStringCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMultiLevelStringCache(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement, DocumentModel.Drawings.Charts.MultiLevelStringCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.MultiLevelStringCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? GetMultiLvlStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MultiLvlStrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMultiLvlStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement, DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.MultiLvlStrRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLevelStringReference? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLevelStringReference();
      value.Formula = GetFormula(openXmlElement);
      value.MultiLevelStringCache = GetMultiLevelStringCache(openXmlElement);
      value.MultiLvlStrRefExtensionList = GetMultiLvlStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MultiLevelStringReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetMultiLevelStringCache(openXmlElement, value?.MultiLevelStringCache);
      SetMultiLvlStrRefExtensionList(openXmlElement, value?.MultiLvlStrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
