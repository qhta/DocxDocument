using DocumentModel.Drawings.Charts;
using DataLabelFieldTable = DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTable Class.
/// </summary>
public static class DataLabelFieldTableConverter
{
  public static Collection<DataLabelFieldTableEntry>? GetDataLabelFieldTableEntries(DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataLabelFieldTableEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>())
      {
        var newItem = DataLabelFieldTableEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDataLabelFieldTableEntries(DataLabelFieldTable? openXmlElement, Collection<DataLabelFieldTableEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataLabelFieldTableEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? CreateModelElement(DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataLabelFieldTable();
      value.DataLabelFieldTableEntries = GetDataLabelFieldTableEntries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataLabelFieldTable? value)
    where OpenXmlElementType : DataLabelFieldTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataLabelFieldTableEntries(openXmlElement, value?.DataLabelFieldTableEntries);
      return openXmlElement;
    }
    return default;
  }
}