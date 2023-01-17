namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public static class NumberReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  private static DocumentModel.Drawings.Charts.NumberingCache? GetNumberingCache(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberingCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingCache(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement, DocumentModel.Drawings.Charts.NumberingCache? value)
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
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Charts.NumRefExtensionList? GetNumRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberReference openXmlElement, DocumentModel.Drawings.Charts.NumRefExtensionList? value)
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetNumberingCache(openXmlElement, value?.NumberingCache);
      SetNumRefExtensionList(openXmlElement, value?.NumRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
