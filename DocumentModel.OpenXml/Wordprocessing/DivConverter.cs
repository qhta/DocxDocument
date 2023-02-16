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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.Div openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  private static Boolean? GetBlockQuote(DXW.Div openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.BlockQuote>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBlockQuote(DXW.Div openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBlockQuote(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BlockQuote", val, value);
    return false;
  }
  
  private static void SetBlockQuote(DXW.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BlockQuote>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BlockQuote();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  private static Boolean? GetBodyDiv(DXW.Div openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.BodyDiv>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpBodyDiv(DXW.Div openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetBodyDiv(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BodyDiv", val, value);
    return false;
  }
  
  private static void SetBodyDiv(DXW.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BodyDiv>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BodyDiv();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  private static String? GetLeftMarginDiv(DXW.Div openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val?.Value;
  }
  
  private static bool CmpLeftMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val?.Value == value;
  }
  
  private static void SetLeftMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LeftMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  private static String? GetRightMarginDiv(DXW.Div openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val?.Value;
  }
  
  private static bool CmpRightMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val?.Value == value;
  }
  
  private static void SetRightMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.RightMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  private static String? GetTopMarginDiv(DXW.Div openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val?.Value;
  }
  
  private static bool CmpTopMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val?.Value == value;
  }
  
  private static void SetTopMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TopMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  private static String? GetBottomMarginDiv(DXW.Div openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val?.Value;
  }
  
  private static bool CmpBottomMarginDiv(DXW.Div openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val?.Value == value;
  }
  
  private static void SetBottomMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.BottomMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.DivsChild>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Div? value)
    where OpenXmlElementType: DXW.Div, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetBlockQuote(openXmlElement, value?.BlockQuote);
      SetBodyDiv(openXmlElement, value?.BodyDiv);
      SetLeftMarginDiv(openXmlElement, value?.LeftMarginDiv);
      SetRightMarginDiv(openXmlElement, value?.RightMarginDiv);
      SetTopMarginDiv(openXmlElement, value?.TopMarginDiv);
      SetBottomMarginDiv(openXmlElement, value?.BottomMarginDiv);
      SetDivBorder(openXmlElement, value?.DivBorder);
      SetDivsChilds(openXmlElement, value?.DivsChilds);
      return openXmlElement;
    }
    return default;
  }
}
