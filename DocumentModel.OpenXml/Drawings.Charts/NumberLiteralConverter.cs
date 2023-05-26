namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Literal.
/// </summary>
public static class NumberLiteralConverter
{
  private static String? GetFormatCode(DXDC.NumberLiteral openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.FormatCode>()?.Text;
  }
  
  private static bool CmpFormatCode(DXDC.NumberLiteral openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.FormatCode>()?.Text == value;
  }
  
  private static void SetFormatCode(DXDC.NumberLiteral openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.FormatCode { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static UInt32? GetPointCount(DXDC.NumberLiteral openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val);
  }
  
  private static bool CmpPointCount(DXDC.NumberLiteral openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.PointCount>()?.Val, value, diffs, objName, "PointCount");
  }
  
  private static void SetPointCount(DXDC.NumberLiteral openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.PointCount,System.UInt32>(openXmlElement, value);
  }
  
  private static Collection<DMDC.NumericPoint>? GetNumericPoints(DXDC.NumberLiteral openXmlElement)
  {
    var collection = new Collection<DMDC.NumericPoint>();
    foreach (var item in openXmlElement.Elements<DXDC.NumericPoint>())
    {
      var newItem = DMXDC.NumericPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericPoints(DXDC.NumberLiteral openXmlElement, Collection<DMDC.NumericPoint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.NumericPoint>();
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
        if (!DMXDC.NumericPointConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericPoints(DXDC.NumberLiteral openXmlElement, Collection<DMDC.NumericPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.NumericPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.NumericPointConverter.CreateOpenXmlElement<DXDC.NumericPoint>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.NumberLiteral openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.NumberLiteral openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.NumberLiteral openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberLiteral? CreateModelElement(DXDC.NumberLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberLiteral();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      value.NumericPoints = GetNumericPoints(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.NumberLiteral? openXmlElement, DMDC.NumberLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName, propName))
        ok = false;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName, propName))
        ok = false;
      if (!CmpNumericPoints(openXmlElement, value.NumericPoints, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.NumberLiteral value)
    where OpenXmlElementType: DXDC.NumberLiteral, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.NumberLiteral openXmlElement, DMDC.NumberLiteral value)
  {
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetPointCount(openXmlElement, value?.PointCount);
    SetNumericPoints(openXmlElement, value?.NumericPoints);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
