using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the HeaderFooter Class.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  ///   alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetAlignWithMargins(HeaderFooter? openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }

  public static void SetAlignWithMargins(HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AlignWithMargins = null;
  }

  /// <summary>
  ///   differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDifferentOddEven(HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }

  public static void SetDifferentOddEven(HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentOddEven = null;
  }

  /// <summary>
  ///   differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDifferentFirst(HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }

  public static void SetDifferentFirst(HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentFirst = null;
  }

  /// <summary>
  ///   OddHeaderXsdstring.
  /// </summary>
  public static String? GetOddHeaderXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OddHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetOddHeaderXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OddHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new OddHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  public static String? GetOddFooterXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OddFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetOddFooterXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OddFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new OddFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  public static String? GetEvenHeaderXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EvenHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEvenHeaderXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EvenHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EvenHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  public static String? GetEvenFooterXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EvenFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEvenFooterXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EvenFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EvenFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  public static String? GetFirstHeaderXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FirstHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFirstHeaderXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FirstHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  public static String? GetFirstFooterXsdstring(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FirstFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFirstFooterXsdstring(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FirstFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.HeaderFooter? CreateModelElement(HeaderFooter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.HeaderFooter();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.HeaderFooter? value)
    where OpenXmlElementType : HeaderFooter, new()
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