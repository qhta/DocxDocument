using DocumentFormat.OpenXml.Drawing.Charts;
using Chart = DocumentModel.Drawings.Charts.Chart;
using ChartSpaceExtensionList = DocumentModel.Drawings.Charts.ChartSpaceExtensionList;
using ColorMapOverride = DocumentModel.Drawings.Charts.ColorMapOverride;
using ExternalData = DocumentModel.Drawings.Charts.ExternalData;
using PivotSource = DocumentModel.Drawings.Charts.PivotSource;
using PrintSettings = DocumentModel.Drawings.Charts.PrintSettings;
using Protection = DocumentModel.Drawings.Charts.Protection;
using RelationshipIdType = DocumentModel.Drawings.Charts.RelationshipIdType;
using ShapeProperties = DocumentModel.Drawings.Charts.ShapeProperties;
using Style = DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Chart Space.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  ///   Date1904.
  /// </summary>
  public static Boolean? GetDate1904(ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Date1904>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDate1904(ChartSpace? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Date1904>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Date1904();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  public static String? GetEditingLanguage(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EditingLanguage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetEditingLanguage(ChartSpace? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EditingLanguage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EditingLanguage { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  public static Boolean? GetRoundedCorners(ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RoundedCorners>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRoundedCorners(ChartSpace? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RoundedCorners>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RoundedCorners();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Byte? GetStyle(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Style>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetStyle(ChartSpace? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Style { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ColorMapOverride? GetColorMapOverride(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>();
    if (itemElement != null)
      return ColorMapOverrideConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorMapOverride(ChartSpace? openXmlElement, ColorMapOverride? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMapOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PivotSource? GetPivotSource(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>();
    if (itemElement != null)
      return PivotSourceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPivotSource(ChartSpace? openXmlElement, PivotSource? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotSourceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Protection? GetProtection(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Protection>();
    if (itemElement != null)
      return ProtectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProtection(ChartSpace? openXmlElement, Protection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Protection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Protection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Chart? GetChart(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Chart>();
    if (itemElement != null)
      return ChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChart(ChartSpace? openXmlElement, Chart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Chart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Chart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties? GetShapeProperties(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(ChartSpace? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextProperties? GetTextProperties(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(ChartSpace? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ExternalData? GetExternalData(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>();
    if (itemElement != null)
      return ExternalDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExternalData(ChartSpace? openXmlElement, ExternalData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExternalDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PrintSettings? GetPrintSettings(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>();
    if (itemElement != null)
      return PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPrintSettings(ChartSpace? openXmlElement, PrintSettings? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RelationshipIdType? GetUserShapesReference(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UserShapesReference>();
    if (itemElement != null)
      return RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUserShapesReference(ChartSpace? openXmlElement, RelationshipIdType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UserShapesReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipIdTypeConverter.CreateOpenXmlElement<UserShapesReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ChartSpaceExtensionList? GetChartSpaceExtensionList(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>();
    if (itemElement != null)
      return ChartSpaceExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartSpaceExtensionList(ChartSpace? openXmlElement, ChartSpaceExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartSpaceExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ChartSpace? CreateModelElement(ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpace();
      value.Date1904 = GetDate1904(openXmlElement);
      value.EditingLanguage = GetEditingLanguage(openXmlElement);
      value.RoundedCorners = GetRoundedCorners(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ColorMapOverride = GetColorMapOverride(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      value.Protection = GetProtection(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExternalData = GetExternalData(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.UserShapesReference = GetUserShapesReference(openXmlElement);
      value.ChartSpaceExtensionList = GetChartSpaceExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpace? value)
    where OpenXmlElementType : ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDate1904(openXmlElement, value?.Date1904);
      SetEditingLanguage(openXmlElement, value?.EditingLanguage);
      SetRoundedCorners(openXmlElement, value?.RoundedCorners);
      SetStyle(openXmlElement, value?.Style);
      SetColorMapOverride(openXmlElement, value?.ColorMapOverride);
      SetPivotSource(openXmlElement, value?.PivotSource);
      SetProtection(openXmlElement, value?.Protection);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExternalData(openXmlElement, value?.ExternalData);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetUserShapesReference(openXmlElement, value?.UserShapesReference);
      SetChartSpaceExtensionList(openXmlElement, value?.ChartSpaceExtensionList);
      return openXmlElement;
    }
    return default;
  }
}