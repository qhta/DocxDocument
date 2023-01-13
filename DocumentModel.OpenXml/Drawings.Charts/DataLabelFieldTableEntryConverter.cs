namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public static class DataLabelFieldTableEntryConverter
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public static String? GetTextFieldGuid(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetTextFieldGuid(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public static DocumentModel.Drawings.Charts.DataLabelFieldTableCache? GetDataLabelFieldTableCache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelFieldTableCache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement, DocumentModel.Drawings.Charts.DataLabelFieldTableCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTableEntry? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelFieldTableEntry();
      value.TextFieldGuid = GetTextFieldGuid(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.DataLabelFieldTableCache = GetDataLabelFieldTableCache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabelFieldTableEntry? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextFieldGuid(openXmlElement, value?.TextFieldGuid);
      SetFormula(openXmlElement, value?.Formula);
      SetDataLabelFieldTableCache(openXmlElement, value?.DataLabelFieldTableCache);
      return openXmlElement;
    }
    return default;
  }
}
