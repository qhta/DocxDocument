namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public static class DataLabelsRangeConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  public static String? GetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula");
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula");
  }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public static DocumentModel.Drawings.Charts.DataLabelsRangeChache? GetDataLabelsRangeChache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeChacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelsRangeChache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? openXmlElement, DocumentModel.Drawings.Charts.DataLabelsRangeChache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeChacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelsRange? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelsRange();
      value.Formula = GetFormula(openXmlElement);
      value.DataLabelsRangeChache = GetDataLabelsRangeChache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabelsRange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetDataLabelsRangeChache(openXmlElement, value?.DataLabelsRangeChache);
      return openXmlElement;
    }
    return default;
  }
}
