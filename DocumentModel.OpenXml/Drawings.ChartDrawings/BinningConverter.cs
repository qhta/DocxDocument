using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Binning = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning;
using IntervalClosedSide = DocumentModel.Drawings.ChartDrawings.IntervalClosedSide;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Binning Class.
/// </summary>
public static class BinningConverter
{
  /// <summary>
  ///   intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public static IntervalClosedSide? GetIntervalClosed(Binning? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, IntervalClosedSide>(openXmlElement?.IntervalClosed?.Value);
  }

  public static void SetIntervalClosed(Binning? openXmlElement, IntervalClosedSide? value)
  {
    if (openXmlElement != null)
      openXmlElement.IntervalClosed = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide, IntervalClosedSide>(value);
  }

  /// <summary>
  ///   underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUnderflow(Binning? openXmlElement)
  {
    return openXmlElement?.Underflow?.Value;
  }

  public static void SetUnderflow(Binning? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Underflow = new StringValue { Value = value };
      else
        openXmlElement.Underflow = null;
  }

  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetOverflow(Binning? openXmlElement)
  {
    return openXmlElement?.Overflow?.Value;
  }

  public static void SetOverflow(Binning? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Overflow = new StringValue { Value = value };
      else
        openXmlElement.Overflow = null;
  }

  /// <summary>
  ///   Xsddouble.
  /// </summary>
  public static String? GetXsddouble(Binning? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Xsddouble>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetXsddouble(Binning? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Xsddouble>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Xsddouble { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  public static String? GetBinCountXsdunsignedInt(Binning? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BinCountXsdunsignedInt>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetBinCountXsdunsignedInt(Binning? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BinCountXsdunsignedInt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BinCountXsdunsignedInt { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Binning? CreateModelElement(Binning? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Binning();
      value.IntervalClosed = GetIntervalClosed(openXmlElement);
      value.Underflow = GetUnderflow(openXmlElement);
      value.Overflow = GetOverflow(openXmlElement);
      value.Xsddouble = GetXsddouble(openXmlElement);
      value.BinCountXsdunsignedInt = GetBinCountXsdunsignedInt(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Binning? value)
    where OpenXmlElementType : Binning, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIntervalClosed(openXmlElement, value?.IntervalClosed);
      SetUnderflow(openXmlElement, value?.Underflow);
      SetOverflow(openXmlElement, value?.Overflow);
      SetXsddouble(openXmlElement, value?.Xsddouble);
      SetBinCountXsdunsignedInt(openXmlElement, value?.BinCountXsdunsignedInt);
      return openXmlElement;
    }
    return default;
  }
}