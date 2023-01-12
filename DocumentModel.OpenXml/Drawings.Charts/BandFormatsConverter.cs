namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Band Formats.
/// </summary>
public static class BandFormatsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BandFormat>? GetItems(DocumentFormat.OpenXml.Drawing.Charts.BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BandFormat>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.BandFormatConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Drawing.Charts.BandFormats? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BandFormat>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.BandFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BandFormat>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BandFormats? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BandFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BandFormats? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BandFormats, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
