namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public static class TabStopListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.TabStop>? GetTabStops(DocumentFormat.OpenXml.Drawing.TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.TabStop>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.TabStop>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.TabStopConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTabStops(DocumentFormat.OpenXml.Drawing.TabStopList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.TabStop>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.TabStop>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.TabStopConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TabStop>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.TabStopList? CreateModelElement(DocumentFormat.OpenXml.Drawing.TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStopList();
      value.TabStops = GetTabStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TabStopList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TabStopList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
