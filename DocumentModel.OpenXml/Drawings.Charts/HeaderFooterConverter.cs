namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  private static Boolean? GetAlignWithMargins(DXDrawCharts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  private static bool CmpAlignWithMargins(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AlignWithMargins?.Value == value;
  }
  
  private static void SetAlignWithMargins(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  private static Boolean? GetDifferentOddEven(DXDrawCharts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  private static bool CmpDifferentOddEven(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DifferentOddEven?.Value == value;
  }
  
  private static void SetDifferentOddEven(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// Different First
  /// </summary>
  private static Boolean? GetDifferentFirst(DXDrawCharts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  private static bool CmpDifferentFirst(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.DifferentFirst?.Value == value;
  }
  
  private static void SetDifferentFirst(DXDrawCharts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  private static String? GetOddHeader(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.OddHeader>()?.Text;
  }
  
  private static bool CmpOddHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.OddHeader>()?.Text == value;
  }
  
  private static void SetOddHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.OddHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.OddHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  private static String? GetOddFooter(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.OddFooter>()?.Text;
  }
  
  private static bool CmpOddFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.OddFooter>()?.Text == value;
  }
  
  private static void SetOddFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.OddFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.OddFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  private static String? GetEvenHeader(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.EvenHeader>()?.Text;
  }
  
  private static bool CmpEvenHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.EvenHeader>()?.Text == value;
  }
  
  private static void SetEvenHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.EvenHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.EvenHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  private static String? GetEvenFooter(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.EvenFooter>()?.Text;
  }
  
  private static bool CmpEvenFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.EvenFooter>()?.Text == value;
  }
  
  private static void SetEvenFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.EvenFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.EvenFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  private static String? GetFirstHeader(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FirstHeader>()?.Text;
  }
  
  private static bool CmpFirstHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FirstHeader>()?.Text == value;
  }
  
  private static void SetFirstHeader(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FirstHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FirstHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  private static String? GetFirstFooter(DXDrawCharts.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FirstFooter>()?.Text;
  }
  
  private static bool CmpFirstFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FirstFooter>()?.Text == value;
  }
  
  private static void SetFirstFooter(DXDrawCharts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FirstFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FirstFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.HeaderFooter? CreateModelElement(DXDrawCharts.HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.HeaderFooter();
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
  
  public static bool CompareModelElement(DXDrawCharts.HeaderFooter? openXmlElement, DMDrawsCharts.HeaderFooter? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.HeaderFooter? value)
    where OpenXmlElementType: DXDrawCharts.HeaderFooter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignWithMargins(openXmlElement, value?.AlignWithMargins);
      SetDifferentOddEven(openXmlElement, value?.DifferentOddEven);
      SetDifferentFirst(openXmlElement, value?.DifferentFirst);
      SetOddHeader(openXmlElement, value?.OddHeader);
      SetOddFooter(openXmlElement, value?.OddFooter);
      SetEvenHeader(openXmlElement, value?.EvenHeader);
      SetEvenFooter(openXmlElement, value?.EvenFooter);
      SetFirstHeader(openXmlElement, value?.FirstHeader);
      SetFirstFooter(openXmlElement, value?.FirstFooter);
      return openXmlElement;
    }
    return default;
  }
}
