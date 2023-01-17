namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Subtotals Class.
/// </summary>
public static class SubtotalsConverter
{
  private static System.Collections.ObjectModel.Collection<UInt32> GetUnsignedIntegerTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetUnsignedIntegerTypes(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Subtotals? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Subtotals();
      value.UnsignedIntegerTypes = GetUnsignedIntegerTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Subtotals? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnsignedIntegerTypes(openXmlElement, value?.UnsignedIntegerTypes);
      return openXmlElement;
    }
    return default;
  }
}
