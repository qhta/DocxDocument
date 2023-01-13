namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public static class DataLabelFieldTableConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>? GetDataLabelFieldTableEntries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableEntryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDataLabelFieldTableEntries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataLabelFieldTableEntry>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.DataLabelFieldTableEntryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelFieldTable? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable, new()
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
