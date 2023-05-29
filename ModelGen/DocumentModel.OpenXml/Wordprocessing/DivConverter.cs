namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public static class DivConverter
{
  /// <summary>
  /// div Data ID
  /// </summary>
  private static String? GetId(DXW.Div openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.Div openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  private static Boolean? GetBlockQuote(DXW.Div openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BlockQuote>());
  }
  
  private static bool CmpBlockQuote(DXW.Div openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BlockQuote>(), value, diffs, objName);
  }
  
  private static void SetBlockQuote(DXW.Div openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BlockQuote>(openXmlElement, value);
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  private static Boolean? GetBodyDiv(DXW.Div openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BodyDiv>());
  }
  
  private static bool CmpBodyDiv(DXW.Div openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BodyDiv>(), value, diffs, objName);
  }
  
  private static void SetBodyDiv(DXW.Div openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BodyDiv>(openXmlElement, value);
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  private static String? GetLeftMarginDiv(DXW.Div openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val);
  }
  
  private static bool CmpLeftMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val, value, diffs, objName, "LeftMarginDiv");
  }
  
  private static void SetLeftMarginDiv(DXW.Div openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.LeftMarginDiv>(openXmlElement, value);
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  private static String? GetRightMarginDiv(DXW.Div openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val);
  }
  
  private static bool CmpRightMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val, value, diffs, objName, "RightMarginDiv");
  }
  
  private static void SetRightMarginDiv(DXW.Div openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.RightMarginDiv>(openXmlElement, value);
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  private static String? GetTopMarginDiv(DXW.Div openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val);
  }
  
  private static bool CmpTopMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val, value, diffs, objName, "TopMarginDiv");
  }
  
  private static void SetTopMarginDiv(DXW.Div openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.TopMarginDiv>(openXmlElement, value);
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  private static String? GetBottomMarginDiv(DXW.Div openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val);
  }
  
  private static bool CmpBottomMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val, value, diffs, objName, "BottomMarginDiv");
  }
  
  private static void SetBottomMarginDiv(DXW.Div openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.BottomMarginDiv>(openXmlElement, value);
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  private static DMW.DivBorder? GetDivBorder(DXW.Div openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DivBorder>();
    if (element != null)
      return DMXW.DivBorderConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDivBorder(DXW.Div openXmlElement, DMW.DivBorder? value, DiffList? diffs, string? objName)
  {
    return DMXW.DivBorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DivBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDivBorder(DXW.Div openXmlElement, DMW.DivBorder? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DivBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DivBorderConverter.CreateOpenXmlElement<DXW.DivBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.DivsChild>? GetDivsChilds(DXW.Div openXmlElement)
  {
    var collection = new Collection<DMW.DivsChild>();
    foreach (var item in openXmlElement.Elements<DXW.DivsChild>())
    {
      var newItem = DMXW.DivsChildConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDivsChilds(DXW.Div openXmlElement, Collection<DMW.DivsChild>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.DivsChild>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.DivsChildConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDivsChilds(DXW.Div openXmlElement, Collection<DMW.DivsChild>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.DivsChild>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.DivsChildConverter.CreateOpenXmlElement<DXW.DivsChild>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Div? CreateModelElement(DXW.Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Div();
      value.Id = GetId(openXmlElement);
      value.BlockQuote = GetBlockQuote(openXmlElement);
      value.BodyDiv = GetBodyDiv(openXmlElement);
      value.LeftMarginDiv = GetLeftMarginDiv(openXmlElement);
      value.RightMarginDiv = GetRightMarginDiv(openXmlElement);
      value.TopMarginDiv = GetTopMarginDiv(openXmlElement);
      value.BottomMarginDiv = GetBottomMarginDiv(openXmlElement);
      value.DivBorder = GetDivBorder(openXmlElement);
      value.DivsChilds = GetDivsChilds(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Div? openXmlElement, DMW.Div? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpBlockQuote(openXmlElement, value.BlockQuote, diffs, objName))
        ok = false;
      if (!CmpBodyDiv(openXmlElement, value.BodyDiv, diffs, objName))
        ok = false;
      if (!CmpLeftMarginDiv(openXmlElement, value.LeftMarginDiv, diffs, objName))
        ok = false;
      if (!CmpRightMarginDiv(openXmlElement, value.RightMarginDiv, diffs, objName))
        ok = false;
      if (!CmpTopMarginDiv(openXmlElement, value.TopMarginDiv, diffs, objName))
        ok = false;
      if (!CmpBottomMarginDiv(openXmlElement, value.BottomMarginDiv, diffs, objName))
        ok = false;
      if (!CmpDivBorder(openXmlElement, value.DivBorder, diffs, objName))
        ok = false;
      if (!CmpDivsChilds(openXmlElement, value.DivsChilds, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Div value)
    where OpenXmlElementType: DXW.Div, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Div openXmlElement, DMW.Div value)
  {
    SetId(openXmlElement, value?.Id);
    SetBlockQuote(openXmlElement, value?.BlockQuote);
    SetBodyDiv(openXmlElement, value?.BodyDiv);
    SetLeftMarginDiv(openXmlElement, value?.LeftMarginDiv);
    SetRightMarginDiv(openXmlElement, value?.RightMarginDiv);
    SetTopMarginDiv(openXmlElement, value?.TopMarginDiv);
    SetBottomMarginDiv(openXmlElement, value?.BottomMarginDiv);
    SetDivBorder(openXmlElement, value?.DivBorder);
    SetDivsChilds(openXmlElement, value?.DivsChilds);
  }
}
