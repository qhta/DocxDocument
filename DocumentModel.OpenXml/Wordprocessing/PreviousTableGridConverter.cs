namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public static class PreviousTableGridConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GridColumn>? GetGridColumns(DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GridColumn>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.GridColumn>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.GridColumnConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetGridColumns(DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GridColumn>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.GridColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.GridColumn>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PreviousTableGrid? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousTableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousTableGrid? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGridColumns(openXmlElement, value?.GridColumns);
      return openXmlElement;
    }
    return default;
  }
}
