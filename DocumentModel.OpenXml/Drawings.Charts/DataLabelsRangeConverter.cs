using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DataLabelsRangeChache = DocumentModel.Drawings.Charts.DataLabelsRangeChache;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRange Class.
/// </summary>
public static class DataLabelsRangeConverter
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public static String? GetFormula(DataLabelsRange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormula(DataLabelsRange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Formula { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataLabelsRangeChache.
  /// </summary>
  public static DataLabelsRangeChache? GetDataLabelsRangeChache(DataLabelsRange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
    if (itemElement != null)
      return DataLabelsRangeChacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelsRangeChache(DataLabelsRange? openXmlElement, DataLabelsRangeChache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsRangeChacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DataLabelsRange? CreateModelElement(DataLabelsRange? openXmlElement)
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
    where OpenXmlElementType : DataLabelsRange, new()
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