namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public static class FormatOverridesConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.FormatOverride> GetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.FormatOverride>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.FormatOverrideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.FormatOverride>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.FormatOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.FormatOverrides? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.FormatOverrides();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.FormatOverrides? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
