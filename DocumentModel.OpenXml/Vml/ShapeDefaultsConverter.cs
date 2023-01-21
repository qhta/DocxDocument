namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public static class ShapeDefaultsConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ShapeDefaults openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.ShapeDefaults openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  private static Int64? GetMaxShapeId(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement.MaxShapeId?.Value;
  }
  
  private static void SetMaxShapeId(DXVmlO.ShapeDefaults openXmlElement, Int64? value)
  {
    openXmlElement.MaxShapeId = value;
  }
  
  /// <summary>
  /// style
  /// </summary>
  private static String? GetStyle(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static void SetStyle(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetBeFilled(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.BeFilled?.Value;
  }
  
  private static void SetBeFilled(DXVmlO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BeFilled = value;
    else
      openXmlElement.BeFilled = null;
  }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  private static String? GetFillColor(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  private static void SetFillColor(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FillColor = new StringValue { Value = value };
    else
      openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetIsStroke(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.IsStroke?.Value;
  }
  
  private static void SetIsStroke(DXVmlO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsStroke = value;
    else
      openXmlElement.IsStroke = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  private static void SetStrokeColor(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StrokeColor = new StringValue { Value = value };
    else
      openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static void SetAllowInCell(DXVmlO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static void SetAllowOverlap(DXVmlO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  private static DMVml.InsetMarginKind? GetInsetMode(DXVmlO.ShapeDefaults openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static void SetInsetMode(DXVmlO.ShapeDefaults openXmlElement, DMVml.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  private static DMVml.Fill? GetFill(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      return DMXVml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFill(DXVmlO.ShapeDefaults openXmlElement, DMVml.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.FillConverter.CreateOpenXmlElement<DXVml.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  private static DMVml.ImageData? GetImageData(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.ImageData>();
    if (itemElement != null)
      return DMXVml.ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageData(DXVmlO.ShapeDefaults openXmlElement, DMVml.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ImageDataConverter.CreateOpenXmlElement<DXVml.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  private static DMVml.Stroke? GetStroke(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Stroke>();
    if (itemElement != null)
      return DMXVml.StrokeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStroke(DXVmlO.ShapeDefaults openXmlElement, DMVml.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeConverter.CreateOpenXmlElement<DXVml.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  private static DMVml.TextBox? GetTextBox(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.TextBox>();
    if (itemElement != null)
      return DMXVml.TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextBox(DXVmlO.ShapeDefaults openXmlElement, DMVml.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.TextBoxConverter.CreateOpenXmlElement<DXVml.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  private static DMVml.Shadow? GetShadow(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVml.Shadow>();
    if (itemElement != null)
      return DMXVml.ShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShadow(DXVmlO.ShapeDefaults openXmlElement, DMVml.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShadowConverter.CreateOpenXmlElement<DXVml.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  private static DMVml.Skew? GetSkew(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Skew>();
    if (itemElement != null)
      return DMXVml.SkewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSkew(DXVmlO.ShapeDefaults openXmlElement, DMVml.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.SkewConverter.CreateOpenXmlElement<DXVmlO.Skew>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  private static DMVml.Extrusion? GetExtrusion(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Extrusion>();
    if (itemElement != null)
      return DMXVml.ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtrusion(DXVmlO.ShapeDefaults openXmlElement, DMVml.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ExtrusionConverter.CreateOpenXmlElement<DXVmlO.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  private static DMVml.Callout? GetCallout(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Callout>();
    if (itemElement != null)
      return DMXVml.CalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCallout(DXVmlO.ShapeDefaults openXmlElement, DMVml.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.CalloutConverter.CreateOpenXmlElement<DXVmlO.Callout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  private static DMVml.Lock? GetLock(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.Lock>();
    if (itemElement != null)
      return DMXVml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLock(DXVmlO.ShapeDefaults openXmlElement, DMVml.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.LockConverter.CreateOpenXmlElement<DXVmlO.Lock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  private static DMVml.ColorMostRecentlyUsed? GetColorMostRecentlyUsed(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ColorMostRecentlyUsed>();
    if (itemElement != null)
      return DMXVml.ColorMostRecentlyUsedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMostRecentlyUsed(DXVmlO.ShapeDefaults openXmlElement, DMVml.ColorMostRecentlyUsed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ColorMostRecentlyUsed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ColorMostRecentlyUsedConverter.CreateOpenXmlElement<DXVmlO.ColorMostRecentlyUsed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  private static DMVml.ColorMenu? GetColorMenu(DXVmlO.ShapeDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.ColorMenu>();
    if (itemElement != null)
      return DMXVml.ColorMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMenu(DXVmlO.ShapeDefaults openXmlElement, DMVml.ColorMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ColorMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ColorMenuConverter.CreateOpenXmlElement<DXVmlO.ColorMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.ShapeDefaults? CreateModelElement(DXVmlO.ShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ShapeDefaults();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeDefaults? value)
    where OpenXmlElementType: DXVmlO.ShapeDefaults, new()
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
