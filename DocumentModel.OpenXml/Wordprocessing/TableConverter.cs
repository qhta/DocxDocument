using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Table Class.
/// </summary>
public static class TableConverter
{
  #region TableProperties conversion
  private static DMW.TableProperties? GetTableProperties(DXW.Table openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableProperties>();
    if (element != null)
      return DMXW.TablePropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableProperties(DXW.Table openXmlElement, DMW.TableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableProperties>(), value, diffs, objName);
  }

  private static void SetTableProperties(DXW.Table openXmlElement, DMW.TableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertiesConverter.CreateOpenXmlElement<DXW.TableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableGrid conversion
  private static DMW.TableGrid? GetTableGrid(DXW.Table openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableGrid>();
    if (element != null)
      return DMXW.TableGridConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableGrid(DXW.Table openXmlElement, DMW.TableGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableGrid>(), value, diffs, objName);
  }

  private static void SetTableGrid(DXW.Table openXmlElement, DMW.TableGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableGridConverter.CreateOpenXmlElement<DXW.TableGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Table elements conversion
  public static DMW.ITableContent? CreateTableElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateModelElement(tableRow);
    if (openXmlElement is DXW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateModelElement(sdtRow);
    if (openXmlElement is DXW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateModelElement(customXmlRow);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in TableConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareTableElement(DX.OpenXmlElement? openXmlElement, DMW.ITableContent? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.TableRow tableRow && value is DMW.TableRow tableRowModel)
        return DMXW.TableRowConverter.CompareModelElement(tableRow, tableRowModel, diffs, objName);
      if (openXmlElement is DXW.SdtRow sdtRow && value is DMW.SdtRow sdtRowModel)
        return DMXW.SdtRowConverter.CompareModelElement(sdtRow, sdtRowModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRow customXmlRow && value is DMW.CustomXmlRow customXmlRowModel)
        return DMXW.CustomXmlRowConverter.CompareModelElement(customXmlRow, customXmlRowModel, diffs, objName);

      if (value is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ITableContent value)
  {
    if (value is DMW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateOpenXmlElement(tableRow);
    if (value is DMW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateOpenXmlElement(sdtRow);
    if (value is DMW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateOpenXmlElement(customXmlRow);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonContent);
    if (result != null) return result;
    throw new InvalidOperationException($"Type of type \"{value.GetType()}\" not supported in TableConverter.CreateOpenXmlParagraphElement method");
  }
  #endregion

  #region Table conversion
  public static DMW.Table? CreateModelElement(DXW.Table? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Table();
      value.TableProperties = GetTableProperties(openXmlElement);
      value.TableGrid = GetTableGrid(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        if (element is DXW.TableProperties)
          continue;
        if (element is DXW.TableGrid)
          continue;
        var item = CreateTableElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Table? openXmlElement, DMW.Table? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTableProperties(openXmlElement, value.TableProperties, diffs, objName))
        ok = false;
      if (!CmpTableGrid(openXmlElement, value.TableGrid, diffs, objName))
        ok = false;
      var tableItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.TableProperties) && !(item is DXW.TableGrid)).ToArray();
      for (int i = 0; i < System.Math.Min(tableItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = tableItems[i];
        if (!CompareTableElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), tableItems.Count(), diffs, objName, "Table.Items.Count"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.Table CreateOpenXmlElement(DMW.Table value)
  {
    var openXmlElement = new DXW.Table();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Table openXmlElement, DMW.Table value)
  {
    SetTableProperties(openXmlElement, value.TableProperties);
    SetTableGrid(openXmlElement, value.TableGrid);
    var tableItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < tableItems.Count(); i++)
    {
      var item = tableItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
    return true;
  }
  #endregion

}
