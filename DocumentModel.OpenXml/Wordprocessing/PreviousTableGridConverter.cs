namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public static class PreviousTableGridConverter
{
  private static Collection<DMW.GridColumn> GetGridColumns(DXW.PreviousTableGrid openXmlElement)
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
  
  private static void SetGridColumns(DXW.PreviousTableGrid openXmlElement, Collection<DMW.GridColumn>? value)
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
  
  public static DMW.PreviousTableGrid? CreateModelElement(DXW.PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousTableGrid();
      value.GridColumns = GetGridColumns(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableGrid? value)
    where OpenXmlElementType: DXW.PreviousTableGrid, new()
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
