using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DataLabelFieldTableCache = DocumentModel.Drawings.Charts.DataLabelFieldTableCache;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public static class DataLabelFieldTableEntryConverter
{
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  public static String? GetTextFieldGuid(DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TextFieldGuid>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetTextFieldGuid(DataLabelFieldTableEntry? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextFieldGuid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TextFieldGuid { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Formula.
  /// </summary>
  public static String? GetFormula(DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormula(DataLabelFieldTableEntry? openXmlElement, String? value)
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
  ///   DataLabelFieldTableCache.
  /// </summary>
  public static DataLabelFieldTableCache? GetDataLabelFieldTableCache(DataLabelFieldTableEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
    if (itemElement != null)
      return DataLabelFieldTableCacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelFieldTableCache(DataLabelFieldTableEntry? openXmlElement, DataLabelFieldTableCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DataLabelFieldTableEntry? CreateModelElement(DataLabelFieldTableEntry? openXmlElement)
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
    where OpenXmlElementType : DataLabelFieldTableEntry, new()
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