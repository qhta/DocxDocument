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
    return openXmlElement?.EqualWidth?.Value;
  }
  
  private static bool CmpEqualWidth(DXW.Columns openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EqualWidth?.Value == value;
  }
  
  private static void SetEqualWidth(DXW.Columns openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EqualWidth = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EqualWidth = null;
  }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  private static String? GetSpace(DXW.Columns openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }
  
  private static bool CmpSpace(DXW.Columns openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Space?.Value == value;
  }
  
  private static void SetSpace(DXW.Columns openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Space = new StringValue { Value = value };
    else
      openXmlElement.Space = null;
  }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  private static Int16? GetColumnCount(DXW.Columns openXmlElement)
  {
    return openXmlElement.ColumnCount?.Value;
  }
  
  private static bool CmpColumnCount(DXW.Columns openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ColumnCount?.Value == value;
  }
  
  private static void SetColumnCount(DXW.Columns openXmlElement, Int16? value)
  {
    openXmlElement.ColumnCount = value;
  }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  private static Boolean? GetSeparator(DXW.Columns openXmlElement)
  {
    return openXmlElement?.Separator?.Value;
  }
  
  private static bool CmpSeparator(DXW.Columns openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Separator?.Value == value;
  }
  
  private static void SetSeparator(DXW.Columns openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Separator = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Separator = null;
  }
  
  private static Collection<DMW.Column> GetItems(DXW.Columns openXmlElement)
  {
    var collection = new Collection<DMW.Column>();
    foreach (var item in openXmlElement.Elements<DXW.Column>())
    {
      var newItem = DMXW.ColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.Columns openXmlElement, Collection<DMW.Column>? value, DiffList? diffs, string? objName)
  {
    return true;
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
          openXmlElement.AddChild(newItem);
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
  
  public static bool CompareModelElement(DXW.Columns? openXmlElement, DMW.Columns? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEqualWidth(openXmlElement, value.EqualWidth, diffs, objName))
        ok = false;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName))
        ok = false;
      if (!CmpColumnCount(openXmlElement, value.ColumnCount, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Columns? value)
    where OpenXmlElementType: DXW.Columns, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEqualWidth(openXmlElement, value?.EqualWidth);
      SetSpace(openXmlElement, value?.Space);
      SetColumnCount(openXmlElement, value?.ColumnCount);
      SetSeparator(openXmlElement, value?.Separator);
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
