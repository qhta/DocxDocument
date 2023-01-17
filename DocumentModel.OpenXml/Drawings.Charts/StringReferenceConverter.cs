namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement, String? value)
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
  /// StringCache.
  /// </summary>
  private static DocumentModel.Drawings.Charts.StringCache? GetStringCache(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringCache(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement, DocumentModel.Drawings.Charts.StringCache? value)
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
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Charts.StrRefExtensionList? GetStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStrRefExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringReference openXmlElement, DocumentModel.Drawings.Charts.StrRefExtensionList? value)
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
