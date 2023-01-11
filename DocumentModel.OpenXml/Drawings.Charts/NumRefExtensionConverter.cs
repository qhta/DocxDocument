namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public static class NumRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FullReference? GetFullReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FullReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFullReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement, DocumentModel.Drawings.Charts.FullReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.LevelReference? GetLevelReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LevelReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLevelReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement, DocumentModel.Drawings.Charts.LevelReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.FormulaReference? GetFormulaReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FormulaReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormulaReference(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement, DocumentModel.Drawings.Charts.FormulaReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.NumRefExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumRefExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
