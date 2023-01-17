namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public static class DataLabelsRangeConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange openXmlElement, String? value)
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
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  private static DocumentModel.Drawings.Charts.DataLabelsRangeChache? GetDataLabelsRangeChache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeChacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelsRangeChache(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange openXmlElement, DocumentModel.Drawings.Charts.DataLabelsRangeChache? value)
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
