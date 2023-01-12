namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extensibility container.
/// </summary>
public static class ChartExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataDisplayOptions16>? GetDataDisplayOptions16s(DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataDisplayOptions16>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.DataDisplayOptions16Converter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDataDisplayOptions16s(DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.DataDisplayOptions16>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.DataDisplayOptions16Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartExtensionList();
      value.DataDisplayOptions16s = GetDataDisplayOptions16s(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
