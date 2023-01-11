namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public static class StylisticSetsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.StyleSet>? GetStyleSets(DocumentFormat.OpenXml.Office2010.Word.StylisticSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.StyleSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Word.StyleSet>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.StyleSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetStyleSets(DocumentFormat.OpenXml.Office2010.Word.StylisticSets? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.StyleSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Word.StyleSet>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.StyleSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.StyleSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.StylisticSets? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.StylisticSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StylisticSets();
      value.StyleSets = GetStyleSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StylisticSets? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.StylisticSets, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
