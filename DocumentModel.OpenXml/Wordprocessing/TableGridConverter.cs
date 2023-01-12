namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public static class TableGridConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GridColumn>? GetGridColumns(DocumentFormat.OpenXml.Wordprocessing.TableGrid? openXmlElement)
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
  
  public static void SetGridColumns(DocumentFormat.OpenXml.Wordprocessing.TableGrid? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.GridColumn>? value)
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
  
  public static DocumentModel.Wordprocessing.TableGridChange? GetTableGridChange(DocumentFormat.OpenXml.Wordprocessing.TableGrid? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableGridChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTableGridChange(DocumentFormat.OpenXml.Wordprocessing.TableGrid? openXmlElement, DocumentModel.Wordprocessing.TableGridChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableGridChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TableGrid? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableGrid? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
