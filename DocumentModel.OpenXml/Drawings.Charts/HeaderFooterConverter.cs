namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  private static Boolean? GetAlignWithMargins(DXDC.HeaderFooter openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  private static bool CmpAlignWithMargins(DXDC.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AlignWithMargins?.Value == value) return true;
    diffs?.Add(objName, "AlignWithMargins", openXmlElement?.AlignWithMargins?.Value, value);
    return false;
  }
  
  private static void SetAlignWithMargins(DXDC.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  private static Boolean? GetDifferentOddEven(DXDC.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  private static bool CmpDifferentOddEven(DXDC.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DifferentOddEven?.Value == value) return true;
    diffs?.Add(objName, "DifferentOddEven", openXmlElement?.DifferentOddEven?.Value, value);
    return false;
  }
  
  private static void SetDifferentOddEven(DXDC.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// Different First
  /// </summary>
  private static Boolean? GetDifferentFirst(DXDC.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  private static bool CmpDifferentFirst(DXDC.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DifferentFirst?.Value == value) return true;
    diffs?.Add(objName, "DifferentFirst", openXmlElement?.DifferentFirst?.Value, value);
    return false;
  }
  
  private static void SetDifferentFirst(DXDC.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  private static String? GetOddHeader(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.OddHeader>()?.Text;
  }
  
  private static bool CmpOddHeader(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.OddHeader>()?.Text == value;
  }
  
  private static void SetOddHeader(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.OddHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.OddHeader { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  private static String? GetOddFooter(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.OddFooter>()?.Text;
  }
  
  private static bool CmpOddFooter(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.OddFooter>()?.Text == value;
  }
  
  private static void SetOddFooter(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.OddFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.OddFooter { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  private static String? GetEvenHeader(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.EvenHeader>()?.Text;
  }
  
  private static bool CmpEvenHeader(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.EvenHeader>()?.Text == value;
  }
  
  private static void SetEvenHeader(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.EvenHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.EvenHeader { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  private static String? GetEvenFooter(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.EvenFooter>()?.Text;
  }
  
  private static bool CmpEvenFooter(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.EvenFooter>()?.Text == value;
  }
  
  private static void SetEvenFooter(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.EvenFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.EvenFooter { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  private static String? GetFirstHeader(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.FirstHeader>()?.Text;
  }
  
  private static bool CmpFirstHeader(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.FirstHeader>()?.Text == value;
  }
  
  private static void SetFirstHeader(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.FirstHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.FirstHeader { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  private static String? GetFirstFooter(DXDC.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.FirstFooter>()?.Text;
  }
  
  private static bool CmpFirstFooter(DXDC.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.FirstFooter>()?.Text == value;
  }
  
  private static void SetFirstFooter(DXDC.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.FirstFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.FirstFooter { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.HeaderFooter? CreateModelElement(DXDC.HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.HeaderFooter();
      value.AlignWithMargins = GetAlignWithMargins(openXmlElement);
      value.DifferentOddEven = GetDifferentOddEven(openXmlElement);
      value.DifferentFirst = GetDifferentFirst(openXmlElement);
      value.OddHeader = GetOddHeader(openXmlElement);
      value.OddFooter = GetOddFooter(openXmlElement);
      value.EvenHeader = GetEvenHeader(openXmlElement);
      value.EvenFooter = GetEvenFooter(openXmlElement);
      value.FirstHeader = GetFirstHeader(openXmlElement);
      value.FirstFooter = GetFirstFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.HeaderFooter? openXmlElement, DMDC.HeaderFooter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlignWithMargins(openXmlElement, value.AlignWithMargins, diffs, objName))
        ok = false;
      if (!CmpDifferentOddEven(openXmlElement, value.DifferentOddEven, diffs, objName))
        ok = false;
      if (!CmpDifferentFirst(openXmlElement, value.DifferentFirst, diffs, objName))
        ok = false;
      if (!CmpOddHeader(openXmlElement, value.OddHeader, diffs, objName))
        ok = false;
      if (!CmpOddFooter(openXmlElement, value.OddFooter, diffs, objName))
        ok = false;
      if (!CmpEvenHeader(openXmlElement, value.EvenHeader, diffs, objName))
        ok = false;
      if (!CmpEvenFooter(openXmlElement, value.EvenFooter, diffs, objName))
        ok = false;
      if (!CmpFirstHeader(openXmlElement, value.FirstHeader, diffs, objName))
        ok = false;
      if (!CmpFirstFooter(openXmlElement, value.FirstFooter, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.HeaderFooter value)
    where OpenXmlElementType: DXDC.HeaderFooter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.HeaderFooter openXmlElement, DMDC.HeaderFooter value)
  {
    SetAlignWithMargins(openXmlElement, value?.AlignWithMargins);
    SetDifferentOddEven(openXmlElement, value?.DifferentOddEven);
    SetDifferentFirst(openXmlElement, value?.DifferentFirst);
    SetOddHeader(openXmlElement, value?.OddHeader);
    SetOddFooter(openXmlElement, value?.OddFooter);
    SetEvenHeader(openXmlElement, value?.EvenHeader);
    SetEvenFooter(openXmlElement, value?.EvenFooter);
    SetFirstHeader(openXmlElement, value?.FirstHeader);
    SetFirstFooter(openXmlElement, value?.FirstFooter);
  }
}
