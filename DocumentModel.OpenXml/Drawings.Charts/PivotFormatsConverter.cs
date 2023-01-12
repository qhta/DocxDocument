namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public static class PivotFormatsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PivotFormat>? GetItems(DocumentFormat.OpenXml.Drawing.Charts.PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PivotFormat>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.PivotFormatConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Drawing.Charts.PivotFormats? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PivotFormat>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.PivotFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotFormat>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotFormats? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PivotFormats? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PivotFormats, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
