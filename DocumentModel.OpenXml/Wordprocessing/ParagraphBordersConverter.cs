namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public static class ParagraphBordersConverter
{
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
  /// </summary>
  private static DMW.BorderType? GetTopBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TopBorder>());
  }
  
  private static bool CmpTopBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TopBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTopBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  private static DMW.BorderType? GetLeftBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.LeftBorder>());
  }
  
  private static bool CmpLeftBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.LeftBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLeftBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  private static DMW.BorderType? GetBottomBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BottomBorder>());
  }
  
  private static bool CmpBottomBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BottomBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBottomBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  private static DMW.BorderType? GetRightBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RightBorder>());
  }
  
  private static bool CmpRightBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RightBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRightBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  private static DMW.BorderType? GetBetweenBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BetweenBorder>());
  }
  
  private static bool CmpBetweenBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BetweenBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBetweenBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  private static DMW.BorderType? GetBarBorder(DXW.ParagraphBorders openXmlElement)
  {
    return DMXW.BorderTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BarBorder>());
  }
  
  private static bool CmpBarBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    return DMXW.BorderTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BarBorder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBarBorder(DXW.ParagraphBorders openXmlElement, DMW.BorderType? value)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphBorders? value)
    where OpenXmlElementType: DXW.ParagraphBorders, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTopBorder(openXmlElement, value?.TopBorder);
      SetLeftBorder(openXmlElement, value?.LeftBorder);
      SetBottomBorder(openXmlElement, value?.BottomBorder);
      SetRightBorder(openXmlElement, value?.RightBorder);
      SetBetweenBorder(openXmlElement, value?.BetweenBorder);
      SetBarBorder(openXmlElement, value?.BarBorder);
      return openXmlElement;
    }
    return default;
  }
}
