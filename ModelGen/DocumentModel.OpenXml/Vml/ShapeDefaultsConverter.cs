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
  
  private static bool CmpExtension(DXVmlO.ShapeDefaults openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.MaxShapeId?.Value;
  }
  
  private static bool CmpMaxShapeId(DXVmlO.ShapeDefaults openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxShapeId?.Value == value) return true;
    diffs?.Add(objName, "MaxShapeId", openXmlElement?.MaxShapeId?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXVmlO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetBeFilled(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.BeFilled?.Value;
  }
  
  private static bool CmpBeFilled(DXVmlO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BeFilled?.Value == value) return true;
    diffs?.Add(objName, "BeFilled", openXmlElement?.BeFilled?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXVmlO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetIsStroke(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.IsStroke?.Value;
  }
  
  private static bool CmpIsStroke(DXVmlO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsStroke?.Value == value) return true;
    diffs?.Add(objName, "IsStroke", openXmlElement?.IsStroke?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXVmlO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXVmlO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVmlO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVmlO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
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
  
  private static bool CmpAllowOverlap(DXVmlO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
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
  
  private static bool CmpInsetMode(DXVmlO.ShapeDefaults openXmlElement, DMVml.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMVml.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Fill>();
    if (element != null)
      return DMXVml.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXVmlO.ShapeDefaults openXmlElement, DMVml.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXVml.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Fill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.ImageData>();
    if (element != null)
      return DMXVml.ImageDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageData(DXVmlO.ShapeDefaults openXmlElement, DMVml.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.ImageData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Stroke>();
    if (element != null)
      return DMXVml.StrokeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStroke(DXVmlO.ShapeDefaults openXmlElement, DMVml.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Stroke>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.TextBox>();
    if (element != null)
      return DMXVml.TextBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBox(DXVmlO.ShapeDefaults openXmlElement, DMVml.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXVml.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.TextBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVml.Shadow>();
    if (element != null)
      return DMXVml.ShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow(DXVmlO.ShapeDefaults openXmlElement, DMVml.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Shadow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.Skew>();
    if (element != null)
      return DMXVml.SkewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSkew(DXVmlO.ShapeDefaults openXmlElement, DMVml.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXVml.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Skew>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.Extrusion>();
    if (element != null)
      return DMXVml.ExtrusionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusion(DXVmlO.ShapeDefaults openXmlElement, DMVml.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Extrusion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.Callout>();
    if (element != null)
      return DMXVml.CalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCallout(DXVmlO.ShapeDefaults openXmlElement, DMVml.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXVml.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Callout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.Lock>();
    if (element != null)
      return DMXVml.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXVmlO.ShapeDefaults openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXVml.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.Lock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.ColorMostRecentlyUsed>();
    if (element != null)
      return DMXVml.ColorMostRecentlyUsedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMostRecentlyUsed(DXVmlO.ShapeDefaults openXmlElement, DMVml.ColorMostRecentlyUsed? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ColorMostRecentlyUsedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ColorMostRecentlyUsed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXVmlO.ColorMenu>();
    if (element != null)
      return DMXVml.ColorMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMenu(DXVmlO.ShapeDefaults openXmlElement, DMVml.ColorMenu? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ColorMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ColorMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Vml.ShapeDefaults? CreateModelElement(DXVmlO.ShapeDefaults? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlO.ShapeDefaults? openXmlElement, DMVml.ShapeDefaults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpMaxShapeId(openXmlElement, value.MaxShapeId, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpBeFilled(openXmlElement, value.BeFilled, diffs, objName))
        ok = false;
      if (!CmpFillColor(openXmlElement, value.FillColor, diffs, objName))
        ok = false;
      if (!CmpIsStroke(openXmlElement, value.IsStroke, diffs, objName))
        ok = false;
      if (!CmpStrokeColor(openXmlElement, value.StrokeColor, diffs, objName))
        ok = false;
      if (!CmpAllowInCell(openXmlElement, value.AllowInCell, diffs, objName))
        ok = false;
      if (!CmpAllowOverlap(openXmlElement, value.AllowOverlap, diffs, objName))
        ok = false;
      if (!CmpInsetMode(openXmlElement, value.InsetMode, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      if (!CmpImageData(openXmlElement, value.ImageData, diffs, objName))
        ok = false;
      if (!CmpStroke(openXmlElement, value.Stroke, diffs, objName))
        ok = false;
      if (!CmpTextBox(openXmlElement, value.TextBox, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpSkew(openXmlElement, value.Skew, diffs, objName))
        ok = false;
      if (!CmpExtrusion(openXmlElement, value.Extrusion, diffs, objName))
        ok = false;
      if (!CmpCallout(openXmlElement, value.Callout, diffs, objName))
        ok = false;
      if (!CmpLock(openXmlElement, value.Lock, diffs, objName))
        ok = false;
      if (!CmpColorMostRecentlyUsed(openXmlElement, value.ColorMostRecentlyUsed, diffs, objName))
        ok = false;
      if (!CmpColorMenu(openXmlElement, value.ColorMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeDefaults value)
    where OpenXmlElementType: DXVmlO.ShapeDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.ShapeDefaults openXmlElement, DMVml.ShapeDefaults value)
  {
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
  }
}
