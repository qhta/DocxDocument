namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public static class ParagraphBordersConverter
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  private static DMW.Border? GetTopBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TopBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName);
  }
  
  private static void SetTopBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Paragraph Border.
  /// </summary>
  private static DMW.Border? GetLeftBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.LeftBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName);
  }
  
  private static void SetLeftBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  private static DMW.Border? GetBottomBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BottomBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName);
  }
  
  private static void SetBottomBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Paragraph Border.
  /// </summary>
  private static DMW.Border? GetRightBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RightBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName);
  }
  
  private static void SetRightBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  private static DMW.Border? GetBetweenBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BetweenBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBetweenBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BetweenBorder>(), value, diffs, objName);
  }
  
  private static void SetBetweenBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BetweenBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BetweenBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  private static DMW.Border? GetBarBorder(DXW.ParagraphBorders openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BarBorder>();
    if (element != null)
      return DMXW.BorderTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BarBorder>(), value, diffs, objName);
  }
  
  private static void SetBarBorder(DXW.ParagraphBorders openXmlElement, DMW.Border? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BarBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BorderTypeConverter.CreateOpenXmlElement<DXW.BarBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.ParagraphBorders? CreateModelElement(DXW.ParagraphBorders? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphBorders();
      value.TopBorder = GetTopBorder(openXmlElement);
      value.LeftBorder = GetLeftBorder(openXmlElement);
      value.BottomBorder = GetBottomBorder(openXmlElement);
      value.RightBorder = GetRightBorder(openXmlElement);
      value.BetweenBorder = GetBetweenBorder(openXmlElement);
      value.BarBorder = GetBarBorder(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphBorders? openXmlElement, DMW.ParagraphBorders? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTopBorder(openXmlElement, value.TopBorder, diffs, objName))
        ok = false;
      if (!CmpLeftBorder(openXmlElement, value.LeftBorder, diffs, objName))
        ok = false;
      if (!CmpBottomBorder(openXmlElement, value.BottomBorder, diffs, objName))
        ok = false;
      if (!CmpRightBorder(openXmlElement, value.RightBorder, diffs, objName))
        ok = false;
      if (!CmpBetweenBorder(openXmlElement, value.BetweenBorder, diffs, objName))
        ok = false;
      if (!CmpBarBorder(openXmlElement, value.BarBorder, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphBorders value)
    where OpenXmlElementType: DXW.ParagraphBorders, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphBorders openXmlElement, DMW.ParagraphBorders value)
  {
    SetTopBorder(openXmlElement, value?.TopBorder);
    SetLeftBorder(openXmlElement, value?.LeftBorder);
    SetBottomBorder(openXmlElement, value?.BottomBorder);
    SetRightBorder(openXmlElement, value?.RightBorder);
    SetBetweenBorder(openXmlElement, value?.BetweenBorder);
    SetBarBorder(openXmlElement, value?.BarBorder);
  }
}
