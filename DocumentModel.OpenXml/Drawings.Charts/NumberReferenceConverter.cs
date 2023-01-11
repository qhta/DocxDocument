namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public static class NumberReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Formula");
  }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  public static DocumentModel.Drawings.Charts.NumberingCache? GetNumberingCache(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingCache(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement, DocumentModel.Drawings.Charts.NumberingCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberingCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Charts.NumRefExtensionList? GetNumRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement, DocumentModel.Drawings.Charts.NumRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.NumRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberReference? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumberReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberReference();
      value.Formula = GetFormula(openXmlElement);
      value.NumberingCache = GetNumberingCache(openXmlElement);
      value.NumRefExtensionList = GetNumRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumberReference, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
