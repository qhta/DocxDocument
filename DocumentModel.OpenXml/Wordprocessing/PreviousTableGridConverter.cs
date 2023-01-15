using DocumentModel.Wordprocessing;
using PreviousTableGrid = DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Previous Table Grid.
/// </summary>
public static class PreviousTableGridConverter
{
  public static Collection<GridColumn>? GetGridColumns(PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<GridColumn>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.GridColumn>())
      {
        var newItem = GridColumnConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetGridColumns(PreviousTableGrid? openXmlElement, Collection<GridColumn>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.GridColumn>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = GridColumnConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.GridColumn>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.PreviousTableGrid? CreateModelElement(PreviousTableGrid? openXmlElement)
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
    where OpenXmlElementType : PreviousTableGrid, new()
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