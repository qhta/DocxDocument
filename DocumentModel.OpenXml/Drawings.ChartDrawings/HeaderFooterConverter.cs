namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetAlignWithMargins(DXO16DCD.HeaderFooter openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  private static bool CmpAlignWithMargins(DXO16DCD.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AlignWithMargins?.Value == value) return true;
    diffs?.Add(objName, "AlignWithMargins", openXmlElement?.AlignWithMargins?.Value, value);
    return false;
  }
  
  private static void SetAlignWithMargins(DXO16DCD.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDifferentOddEven(DXO16DCD.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  private static bool CmpDifferentOddEven(DXO16DCD.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DifferentOddEven?.Value == value) return true;
    diffs?.Add(objName, "DifferentOddEven", openXmlElement?.DifferentOddEven?.Value, value);
    return false;
  }
  
  private static void SetDifferentOddEven(DXO16DCD.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDifferentFirst(DXO16DCD.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  private static bool CmpDifferentFirst(DXO16DCD.HeaderFooter openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DifferentFirst?.Value == value) return true;
    diffs?.Add(objName, "DifferentFirst", openXmlElement?.DifferentFirst?.Value, value);
    return false;
  }
  
  private static void SetDifferentFirst(DXO16DCD.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  private static String? GetOddHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.OddHeaderXsdstring>()?.Text;
  }
  
  private static bool CmpOddHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.OddHeaderXsdstring>()?.Text == value;
  }
  
  private static void SetOddHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.OddHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.OddHeaderXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  private static String? GetOddFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.OddFooterXsdstring>()?.Text;
  }
  
  private static bool CmpOddFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.OddFooterXsdstring>()?.Text == value;
  }
  
  private static void SetOddFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.OddFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.OddFooterXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  private static String? GetEvenHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.EvenHeaderXsdstring>()?.Text;
  }
  
  private static bool CmpEvenHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.EvenHeaderXsdstring>()?.Text == value;
  }
  
  private static void SetEvenHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.EvenHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.EvenHeaderXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  private static String? GetEvenFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.EvenFooterXsdstring>()?.Text;
  }
  
  private static bool CmpEvenFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.EvenFooterXsdstring>()?.Text == value;
  }
  
  private static void SetEvenFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.EvenFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.EvenFooterXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  private static String? GetFirstHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.FirstHeaderXsdstring>()?.Text;
  }
  
  private static bool CmpFirstHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.FirstHeaderXsdstring>()?.Text == value;
  }
  
  private static void SetFirstHeaderXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.FirstHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.FirstHeaderXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  private static String? GetFirstFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.FirstFooterXsdstring>()?.Text;
  }
  
  private static bool CmpFirstFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.FirstFooterXsdstring>()?.Text == value;
  }
  
  private static void SetFirstFooterXsdstring(DXO16DCD.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.FirstFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.FirstFooterXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.HeaderFooter? CreateModelElement(DXO16DCD.HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.HeaderFooter();
      value.AlignWithMargins = GetAlignWithMargins(openXmlElement);
      value.DifferentOddEven = GetDifferentOddEven(openXmlElement);
      value.DifferentFirst = GetDifferentFirst(openXmlElement);
      value.OddHeaderXsdstring = GetOddHeaderXsdstring(openXmlElement);
      value.OddFooterXsdstring = GetOddFooterXsdstring(openXmlElement);
      value.EvenHeaderXsdstring = GetEvenHeaderXsdstring(openXmlElement);
      value.EvenFooterXsdstring = GetEvenFooterXsdstring(openXmlElement);
      value.FirstHeaderXsdstring = GetFirstHeaderXsdstring(openXmlElement);
      value.FirstFooterXsdstring = GetFirstFooterXsdstring(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.HeaderFooter? openXmlElement, DMDCDs.HeaderFooter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlignWithMargins(openXmlElement, value.AlignWithMargins, diffs, objName, propName))
        ok = false;
      if (!CmpDifferentOddEven(openXmlElement, value.DifferentOddEven, diffs, objName, propName))
        ok = false;
      if (!CmpDifferentFirst(openXmlElement, value.DifferentFirst, diffs, objName, propName))
        ok = false;
      if (!CmpOddHeaderXsdstring(openXmlElement, value.OddHeaderXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpOddFooterXsdstring(openXmlElement, value.OddFooterXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpEvenHeaderXsdstring(openXmlElement, value.EvenHeaderXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpEvenFooterXsdstring(openXmlElement, value.EvenFooterXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpFirstHeaderXsdstring(openXmlElement, value.FirstHeaderXsdstring, diffs, objName, propName))
        ok = false;
      if (!CmpFirstFooterXsdstring(openXmlElement, value.FirstFooterXsdstring, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.HeaderFooter value)
    where OpenXmlElementType: DXO16DCD.HeaderFooter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.HeaderFooter openXmlElement, DMDCDs.HeaderFooter value)
  {
    SetAlignWithMargins(openXmlElement, value?.AlignWithMargins);
    SetDifferentOddEven(openXmlElement, value?.DifferentOddEven);
    SetDifferentFirst(openXmlElement, value?.DifferentFirst);
    SetOddHeaderXsdstring(openXmlElement, value?.OddHeaderXsdstring);
    SetOddFooterXsdstring(openXmlElement, value?.OddFooterXsdstring);
    SetEvenHeaderXsdstring(openXmlElement, value?.EvenHeaderXsdstring);
    SetEvenFooterXsdstring(openXmlElement, value?.EvenFooterXsdstring);
    SetFirstHeaderXsdstring(openXmlElement, value?.FirstHeaderXsdstring);
    SetFirstFooterXsdstring(openXmlElement, value?.FirstFooterXsdstring);
  }
}
