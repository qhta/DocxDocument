namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
public static class TableCellConverter
{
  #region Table Cell Properties conversion
  private static DMW.TableCellProperties? GetTableCellProperties(DXW.TableCell openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellProperties>();
    if (element != null)
      return DMXW.TableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellProperties(DXW.TableCell openXmlElement, DMW.TableCellProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTableCellProperties(DXW.TableCell openXmlElement, DMW.TableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellPropertiesConverter.CreateOpenXmlElement<DXW.TableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableCell elements conversion
  public static DMW.ITableCellContent? CreateTableCellElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(sdtBlock);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);
    if (openXmlElement is DXW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateModelElement(altChunk);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in TableCellConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareTableCellElement(DX.OpenXmlElement? openXmlElement, DMW.ITableCellContent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && value is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName, propName);
      if (openXmlElement is DXW.Table table && value is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName, propName);
      if (openXmlElement is DXW.SdtBlock sdtBlock && value is DMW.SdtBlock sdtBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(sdtBlock, sdtBlockModel, diffs, objName, propName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && value is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName, propName);
      if (openXmlElement is DXW.AltChunk altChunk && value is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName, propName);

      if (value is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName, propName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ITableCellContent value)
  {
    if (value is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (value is DMW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(sdtBlock);
    if (value is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonContent);
    if (result != null) return result;
    throw new InvalidOperationException($"Type of type \"{value.GetType()}\" not supported in TableCellConverter.CreateOpenXmlParagraphContent method");
  }
  #endregion

  #region TableCell conversion
  public static DMW.TableCell? CreateModelElement(DXW.TableCell? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCell();
      value.TableCellProperties = GetTableCellProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        if (element is DXW.TableCellProperties)
          continue;
        var item = CreateTableCellElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCell? openXmlElement, DMW.TableCell? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableCellProperties(openXmlElement, value.TableCellProperties, diffs, objName, propName))
        ok = false;
      var tableRowItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.TableCellProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(tableRowItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = tableRowItems[i];
        if (!CompareTableCellElement(element, item, diffs, objName, propName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), tableRowItems.Count(), diffs, objName, "TableRow.Items.Count"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.TableCell CreateOpenXmlElement(DMW.TableCell value)
  {
    var openXmlElement = new DXW.TableCell();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.TableCell openXmlElement, DMW.TableCell value)
  {
    SetTableCellProperties(openXmlElement, value.TableCellProperties);
    var tableCellItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < tableCellItems.Count(); i++)
    {
      var item = tableCellItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AppendChild(element);
      }
    }
    return true;
  }
  #endregion
}
