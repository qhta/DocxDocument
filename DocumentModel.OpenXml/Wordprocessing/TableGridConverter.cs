using DocumentModel.Wordprocessing;
using TableGrid = DocumentFormat.OpenXml.Wordprocessing.TableGrid;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Table Grid.
/// </summary>
public static class TableGridConverter
{
  public static Collection<GridColumn>? GetGridColumns(TableGrid? openXmlElement)
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

  public static void SetGridColumns(TableGrid? openXmlElement, Collection<GridColumn>? value)
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

  public static TableGridChange? GetTableGridChange(TableGrid? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
    if (itemElement != null)
      return TableGridChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTableGridChange(TableGrid? openXmlElement, TableGridChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableGridChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TableGrid? CreateModelElement(TableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      value.TableGridChange = GetTableGridChange(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableGrid? value)
    where OpenXmlElementType : TableGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGridColumns(openXmlElement, value?.GridColumns);
      SetTableGridChange(openXmlElement, value?.TableGridChange);
      return openXmlElement;
    }
    return default;
  }
}