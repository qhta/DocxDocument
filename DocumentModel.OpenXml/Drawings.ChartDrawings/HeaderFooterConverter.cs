namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetAlignWithMargins(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  private static void SetAlignWithMargins(DXO2016DrawChartDraw.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDifferentOddEven(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  private static void SetDifferentOddEven(DXO2016DrawChartDraw.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDifferentFirst(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  private static void SetDifferentFirst(DXO2016DrawChartDraw.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  private static String? GetOddHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.OddHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetOddHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.OddHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.OddHeaderXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  private static String? GetOddFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.OddFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetOddFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.OddFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.OddFooterXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  private static String? GetEvenHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.EvenHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetEvenHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.EvenHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.EvenHeaderXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  private static String? GetEvenFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.EvenFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetEvenFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.EvenFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.EvenFooterXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  private static String? GetFirstHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.FirstHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFirstHeaderXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.FirstHeaderXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.FirstHeaderXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  private static String? GetFirstFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.FirstFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFirstFooterXsdstring(DXO2016DrawChartDraw.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.FirstFooterXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.FirstFooterXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.HeaderFooter? CreateModelElement(DXO2016DrawChartDraw.HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.HeaderFooter();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.HeaderFooter? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.HeaderFooter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignWithMargins(openXmlElement, value?.AlignWithMargins);
      SetDifferentOddEven(openXmlElement, value?.DifferentOddEven);
      SetDifferentFirst(openXmlElement, value?.DifferentFirst);
      SetOddHeaderXsdstring(openXmlElement, value?.OddHeaderXsdstring);
      SetOddFooterXsdstring(openXmlElement, value?.OddFooterXsdstring);
      SetEvenHeaderXsdstring(openXmlElement, value?.EvenHeaderXsdstring);
      SetEvenFooterXsdstring(openXmlElement, value?.EvenFooterXsdstring);
      SetFirstHeaderXsdstring(openXmlElement, value?.FirstHeaderXsdstring);
      SetFirstFooterXsdstring(openXmlElement, value?.FirstFooterXsdstring);
      return openXmlElement;
    }
    return default;
  }
}
