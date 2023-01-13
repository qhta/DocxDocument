namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public static class HeaderFooterConverter
{
  /// <summary>
  /// alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetAlignWithMargins(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.AlignWithMargins?.Value;
  }
  
  public static void SetAlignWithMargins(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AlignWithMargins = null;
  }
  
  /// <summary>
  /// differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDifferentOddEven(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentOddEven?.Value;
  }
  
  public static void SetDifferentOddEven(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentOddEven = null;
  }
  
  /// <summary>
  /// differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDifferentFirst(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    return openXmlElement?.DifferentFirst?.Value;
  }
  
  public static void SetDifferentFirst(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.DifferentFirst = null;
  }
  
  /// <summary>
  /// OddHeaderXsdstring.
  /// </summary>
  public static String? GetOddHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetOddHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// OddFooterXsdstring.
  /// </summary>
  public static String? GetOddFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetOddFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EvenHeaderXsdstring.
  /// </summary>
  public static String? GetEvenHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEvenHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EvenFooterXsdstring.
  /// </summary>
  public static String? GetEvenFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEvenFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FirstHeaderXsdstring.
  /// </summary>
  public static String? GetFirstHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetFirstHeaderXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// FirstFooterXsdstring.
  /// </summary>
  public static String? GetFirstFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetFirstFooterXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.HeaderFooter? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter, new()
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
