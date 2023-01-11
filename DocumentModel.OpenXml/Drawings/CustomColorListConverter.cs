namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public static class CustomColorListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.CustomColor>? GetCustomColors(DocumentFormat.OpenXml.Drawing.CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.CustomColor>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.CustomColor>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.CustomColorConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCustomColors(DocumentFormat.OpenXml.Drawing.CustomColorList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.CustomColor>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.CustomColor>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.CustomColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomColor>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomColorList? CreateModelElement(DocumentFormat.OpenXml.Drawing.CustomColorList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CustomColorList();
      value.CustomColors = GetCustomColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.CustomColorList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.CustomColorList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
