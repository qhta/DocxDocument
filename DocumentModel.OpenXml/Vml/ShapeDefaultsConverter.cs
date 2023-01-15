using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Callout = DocumentModel.Vml.Callout;
using ColorMenu = DocumentModel.Vml.ColorMenu;
using ColorMostRecentlyUsed = DocumentModel.Vml.ColorMostRecentlyUsed;
using Extrusion = DocumentModel.Vml.Extrusion;
using Fill = DocumentModel.Vml.Fill;
using ImageData = DocumentModel.Vml.ImageData;
using Lock = DocumentModel.Vml.Lock;
using Shadow = DocumentModel.Vml.Shadow;
using ShapeDefaults = DocumentFormat.OpenXml.Vml.Office.ShapeDefaults;
using Skew = DocumentModel.Vml.Skew;
using Stroke = DocumentModel.Vml.Stroke;
using TextBox = DocumentModel.Vml.TextBox;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   New Shape Defaults.
/// </summary>
public static class ShapeDefaultsConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(ShapeDefaults? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Shape ID Optional Storage
  /// </summary>
  public static Int64? GetMaxShapeId(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.MaxShapeId?.Value;
  }

  public static void SetMaxShapeId(ShapeDefaults? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.MaxShapeId = value;
  }

  /// <summary>
  ///   style
  /// </summary>
  public static String? GetStyle(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public static Boolean? GetBeFilled(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.BeFilled?.Value;
  }

  public static void SetBeFilled(ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BeFilled = value;
      else
        openXmlElement.BeFilled = null;
  }

  /// <summary>
  ///   Default Fill Color
  /// </summary>
  public static String? GetFillColor(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }

  public static void SetFillColor(ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }

  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public static Boolean? GetIsStroke(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.IsStroke?.Value;
  }

  public static void SetIsStroke(ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsStroke = value;
      else
        openXmlElement.IsStroke = null;
  }

  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public static String? GetStrokeColor(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }

  public static void SetStrokeColor(ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }

  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }

  public static void SetAllowInCell(ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInCell = value;
      else
        openXmlElement.AllowInCell = null;
  }

  /// <summary>
  ///   allowoverlap
  /// </summary>
  public static Boolean? GetAllowOverlap(ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }

  public static void SetAllowOverlap(ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = value;
      else
        openXmlElement.AllowOverlap = null;
  }

  /// <summary>
  ///   insetmode
  /// </summary>
  public static InsetMarginKind? GetInsetMode(ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<InsetMarginValues, InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }

  public static void SetInsetMode(ShapeDefaults? openXmlElement, InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<InsetMarginValues, InsetMarginKind>(value);
  }

  /// <summary>
  ///   Fill.
  /// </summary>
  public static Fill? GetFill(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return FillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFill(ShapeDefaults? openXmlElement, Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ImageData.
  /// </summary>
  public static ImageData? GetImageData(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageData(ShapeDefaults? openXmlElement, ImageData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Stroke.
  /// </summary>
  public static Stroke? GetStroke(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return StrokeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStroke(ShapeDefaults? openXmlElement, Stroke? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Stroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TextBox.
  /// </summary>
  public static TextBox? GetTextBox(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBox(ShapeDefaults? openXmlElement, TextBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shadow.
  /// </summary>
  public static Shadow? GetShadow(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return ShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShadow(ShapeDefaults? openXmlElement, Shadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Skew.
  /// </summary>
  public static Skew? GetSkew(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return SkewConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSkew(ShapeDefaults? openXmlElement, Skew? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SkewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Skew>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Extrusion.
  /// </summary>
  public static Extrusion? GetExtrusion(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtrusion(ShapeDefaults? openXmlElement, Extrusion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Extrusion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Callout.
  /// </summary>
  public static Callout? GetCallout(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return CalloutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCallout(ShapeDefaults? openXmlElement, Callout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Callout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Protections.
  /// </summary>
  public static Lock? GetLock(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return LockConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLock(ShapeDefaults? openXmlElement, Lock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Lock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Most Recently Used Colors.
  /// </summary>
  public static ColorMostRecentlyUsed? GetColorMostRecentlyUsed(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
    if (itemElement != null)
      return ColorMostRecentlyUsedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorMostRecentlyUsed(ShapeDefaults? openXmlElement, ColorMostRecentlyUsed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMostRecentlyUsedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   UI Default Colors.
  /// </summary>
  public static ColorMenu? GetColorMenu(ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
    if (itemElement != null)
      return ColorMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorMenu(ShapeDefaults? openXmlElement, ColorMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ColorMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.ShapeDefaults? CreateModelElement(ShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeDefaults();
      value.Extension = GetExtension(openXmlElement);
      value.MaxShapeId = GetMaxShapeId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.BeFilled = GetBeFilled(openXmlElement);
      value.FillColor = GetFillColor(openXmlElement);
      value.IsStroke = GetIsStroke(openXmlElement);
      value.StrokeColor = GetStrokeColor(openXmlElement);
      value.AllowInCell = GetAllowInCell(openXmlElement);
      value.AllowOverlap = GetAllowOverlap(openXmlElement);
      value.InsetMode = GetInsetMode(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.ImageData = GetImageData(openXmlElement);
      value.Stroke = GetStroke(openXmlElement);
      value.TextBox = GetTextBox(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Skew = GetSkew(openXmlElement);
      value.Extrusion = GetExtrusion(openXmlElement);
      value.Callout = GetCallout(openXmlElement);
      value.Lock = GetLock(openXmlElement);
      value.ColorMostRecentlyUsed = GetColorMostRecentlyUsed(openXmlElement);
      value.ColorMenu = GetColorMenu(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeDefaults? value)
    where OpenXmlElementType : ShapeDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetMaxShapeId(openXmlElement, value?.MaxShapeId);
      SetStyle(openXmlElement, value?.Style);
      SetBeFilled(openXmlElement, value?.BeFilled);
      SetFillColor(openXmlElement, value?.FillColor);
      SetIsStroke(openXmlElement, value?.IsStroke);
      SetStrokeColor(openXmlElement, value?.StrokeColor);
      SetAllowInCell(openXmlElement, value?.AllowInCell);
      SetAllowOverlap(openXmlElement, value?.AllowOverlap);
      SetInsetMode(openXmlElement, value?.InsetMode);
      SetFill(openXmlElement, value?.Fill);
      SetImageData(openXmlElement, value?.ImageData);
      SetStroke(openXmlElement, value?.Stroke);
      SetTextBox(openXmlElement, value?.TextBox);
      SetShadow(openXmlElement, value?.Shadow);
      SetSkew(openXmlElement, value?.Skew);
      SetExtrusion(openXmlElement, value?.Extrusion);
      SetCallout(openXmlElement, value?.Callout);
      SetLock(openXmlElement, value?.Lock);
      SetColorMostRecentlyUsed(openXmlElement, value?.ColorMostRecentlyUsed);
      SetColorMenu(openXmlElement, value?.ColorMenu);
      return openXmlElement;
    }
    return default;
  }
}