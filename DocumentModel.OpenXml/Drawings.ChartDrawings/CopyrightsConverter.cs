namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Copyrights Class.
/// </summary>
public static class CopyrightsConverter
{
  private static System.Collections.ObjectModel.Collection<String> GetCopyrightXsdstrings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<String>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static void SetCopyrightXsdstrings(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CopyrightXsdstring>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Copyrights? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Copyrights();
      value.CopyrightXsdstrings = GetCopyrightXsdstrings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Copyrights? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Copyrights, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCopyrightXsdstrings(openXmlElement, value?.CopyrightXsdstrings);
      return openXmlElement;
    }
    return default;
  }
}
