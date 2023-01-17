namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public static class StrRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FullReference? GetFullReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FullReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFullReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement, DocumentModel.Drawings.Charts.FullReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FullReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.LevelReference? GetLevelReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LevelReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevelReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement, DocumentModel.Drawings.Charts.LevelReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.LevelReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.FormulaReference? GetFormulaReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FormulaReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormulaReference(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension openXmlElement, DocumentModel.Drawings.Charts.FormulaReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.FormulaReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrRefExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrRefExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFullReference(openXmlElement, value?.FullReference);
      SetLevelReference(openXmlElement, value?.LevelReference);
      SetFormulaReference(openXmlElement, value?.FormulaReference);
      return openXmlElement;
    }
    return default;
  }
}
