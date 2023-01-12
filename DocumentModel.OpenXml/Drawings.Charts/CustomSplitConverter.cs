namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Custom Split.
/// </summary>
public static class CustomSplitConverter
{
  public static System.Collections.ObjectModel.Collection<UInt32>? GetSecondPiePoints(DocumentFormat.OpenXml.Drawing.Charts.CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSecondPiePoints(DocumentFormat.OpenXml.Drawing.Charts.CustomSplit? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CustomSplit? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CustomSplit();
      value.SecondPiePoints = GetSecondPiePoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CustomSplit? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.CustomSplit, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
