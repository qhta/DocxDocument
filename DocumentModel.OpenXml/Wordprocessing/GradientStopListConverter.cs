namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public static class GradientStopListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GradientStop>? GetGradientStops(DocumentFormat.OpenXml.Office2010.Word.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GradientStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.GradientStop>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.GradientStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetGradientStops(DocumentFormat.OpenXml.Office2010.Word.GradientStopList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GradientStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.GradientStop>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.GradientStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.GradientStopList? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientStopList();
      value.GradientStops = GetGradientStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientStopList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.GradientStopList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
