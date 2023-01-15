using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Header and Footer.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  ///   Align With Margins
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
  ///   Different Odd Even
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
  ///   Different First
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
  ///   Odd Header.
  /// </summary>
  public static String? GetOddHeader(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OddHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetOddHeader(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OddHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new OddHeader { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Odd Footer.
  /// </summary>
  public static String? GetOddFooter(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<OddFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetOddFooter(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OddFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new OddFooter { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Even Header.
  /// </summary>
  public static String? GetEvenHeader(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EvenHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEvenHeader(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EvenHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EvenHeader { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Even Footer.
  /// </summary>
  public static String? GetEvenFooter(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EvenFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEvenFooter(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EvenFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EvenFooter { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   First Header.
  /// </summary>
  public static String? GetFirstHeader(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FirstHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFirstHeader(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FirstHeader { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   First Footer.
  /// </summary>
  public static String? GetFirstFooter(HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FirstFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFirstFooter(HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FirstFooter { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.HeaderFooter? CreateModelElement(HeaderFooter? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.HeaderFooter? value)
    where OpenXmlElementType : HeaderFooter, new()
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