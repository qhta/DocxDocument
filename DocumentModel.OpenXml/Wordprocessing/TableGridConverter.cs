namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public static class TableGridConverter
{
  private static Collection<DMW.GridColumn> GetGridColumns(DXW.TableGrid openXmlElement)
  {
    var collection = new Collection<DMW.GridColumn>();
    foreach (var item in openXmlElement.Elements<DXW.GridColumn>())
    {
      var newItem = DMXW.GridColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetGridColumns(DXW.TableGrid openXmlElement, Collection<DMW.GridColumn>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.GridColumn>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.GridColumnConverter.CreateOpenXmlElement<DXW.GridColumn>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.TableGridChange? GetTableGridChange(DXW.TableGrid openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableGridChange>();
    if (itemElement != null)
      return DMXW.TableGridChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableGridChange(DXW.TableGrid openXmlElement, DMW.TableGridChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableGridChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableGridChangeConverter.CreateOpenXmlElement<DXW.TableGridChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableGrid? CreateModelElement(DXW.TableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      value.TableGridChange = GetTableGridChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableGrid? value)
    where OpenXmlElementType: DXW.TableGrid, new()
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
