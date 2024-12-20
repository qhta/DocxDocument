namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public static class ColumnsConverter
{
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  private static Boolean? GetEqualWidth(DXW.Columns openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.EqualWidth);
  }
  
  private static bool CmpEqualWidth(DXW.Columns openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.EqualWidth, value, diffs, objName, "EqualWidth");
  }
  
  private static void SetEqualWidth(DXW.Columns openXmlElement, Boolean? value)
  {
    openXmlElement.EqualWidth = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  private static Int32? GetSpace(DXW.Columns? openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Space);
  }
  
  private static bool CmpSpace(DXW.Columns openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Space, value, diffs, objName, "Space");
  }
  
  private static void SetSpace(DXW.Columns openXmlElement, String? value)
  {
    openXmlElement.Space = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  private static int? GetColumnCount(DXW.Columns openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }
  
  private static bool CmpColumnCount(DXW.Columns openXmlElement, int? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnCount?.Value == value) return true;
    diffs?.Add(objName, "ColumnCount", openXmlElement?.ColumnCount?.Value, value);
    return false;
  }
  
  private static void SetColumnCount(DXW.Columns openXmlElement, int? value)
  {
    openXmlElement.ColumnCount = (Int16?)value;
  }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  private static Boolean? GetSeparator(DXW.Columns openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Separator);
  }
  
  private static bool CmpSeparator(DXW.Columns openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Separator, value, diffs, objName, "Separator");
  }
  
  private static void SetSeparator(DXW.Columns openXmlElement, Boolean? value)
  {
    openXmlElement.Separator = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  private static Collection<DMW.Column>? GetItems(DXW.Columns openXmlElement)
  {
    var collection = new Collection<DMW.Column>();
    foreach (var item in openXmlElement.Elements<DXW.Column>())
    {
      var newItem = DMXW.ColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.Columns openXmlElement, Collection<DMW.Column>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.Column>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.ColumnConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Columns openXmlElement, Collection<DMW.Column>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Column>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.ColumnConverter.CreateOpenXmlElement<DXW.Column>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMW.Columns? CreateModelElement(DXW.Columns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Columns();
      value.EqualWidth = GetEqualWidth(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.ColumnCount = GetColumnCount(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Columns? openXmlElement, DMW.Columns? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEqualWidth(openXmlElement, value.EqualWidth, diffs, objName, propName))
        ok = false;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName, propName))
        ok = false;
      if (!CmpColumnCount(openXmlElement, value.ColumnCount, diffs, objName, propName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName, propName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Columns value)
    where OpenXmlElementType: DXW.Columns, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Columns openXmlElement, DMW.Columns value)
  {
    SetEqualWidth(openXmlElement, value?.EqualWidth);
    SetSpace(openXmlElement, value?.Space);
    SetColumnCount(openXmlElement, value?.ColumnCount);
    SetSeparator(openXmlElement, value?.Separator);
    SetItems(openXmlElement, value?.Items);
  }
}
