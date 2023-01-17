namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Header and Footer.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// Align With Margins
  /// </summary>
  private static Boolean? GetAlignWithMargins(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  private static void SetAlignWithMargins(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// Different Odd Even
  /// </summary>
  private static Boolean? GetDifferentOddEven(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  private static void SetDifferentOddEven(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// Different First
  /// </summary>
  private static Boolean? GetDifferentFirst(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  private static void SetDifferentFirst(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// Odd Header.
  /// </summary>
  private static String? GetOddHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OddHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetOddHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OddHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.OddHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Odd Footer.
  /// </summary>
  private static String? GetOddFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OddFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetOddFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OddFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.OddFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Header.
  /// </summary>
  private static String? GetEvenHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EvenHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetEvenHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EvenHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.EvenHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Even Footer.
  /// </summary>
  private static String? GetEvenFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EvenFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetEvenFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EvenFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.EvenFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Header.
  /// </summary>
  private static String? GetFirstHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FirstHeader>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFirstHeader(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FirstHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.FirstHeader { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Footer.
  /// </summary>
  private static String? GetFirstFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FirstFooter>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFirstFooter(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FirstFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.FirstFooter { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.HeaderFooter? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter, new()
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
