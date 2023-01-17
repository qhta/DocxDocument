namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public static class MultiLevelStringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement, String? value)
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
  /// MultiLevelStringCache.
  /// </summary>
  private static DocumentModel.Drawings.Charts.MultiLevelStringCache? GetMultiLevelStringCache(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MultiLevelStringCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMultiLevelStringCache(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement, DocumentModel.Drawings.Charts.MultiLevelStringCache? value)
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
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? GetMultiLvlStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MultiLvlStrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMultiLvlStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement, DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? value)
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
