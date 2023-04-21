namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public static class ShapeDefaultsConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.ShapeDefaults openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.ShapeDefaults openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVO.ShapeDefaults openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  private static Int64? GetMaxShapeId(DXVO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.MaxShapeId?.Value;
  }
  
  private static bool CmpMaxShapeId(DXVO.ShapeDefaults openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxShapeId?.Value == value) return true;
    diffs?.Add(objName, "MaxShapeId", openXmlElement?.MaxShapeId?.Value, value);
    return false;
  }
  
  private static void SetMaxShapeId(DXVO.ShapeDefaults openXmlElement, Int64? value)
  {
    openXmlElement.MaxShapeId = value;
  }
  
  /// <summary>
  /// style
  /// </summary>
  private static String? GetStyle(DXVO.ShapeDefaults openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXVO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXVO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetBeFilled(DXVO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.BeFilled?.Value;
  }
  
  private static bool CmpBeFilled(DXVO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BeFilled?.Value == value) return true;
    diffs?.Add(objName, "BeFilled", openXmlElement?.BeFilled?.Value, value);
    return false;
  }
  
  private static void SetBeFilled(DXVO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BeFilled = value;
    else
      openXmlElement.BeFilled = null;
  }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  private static String? GetFillColor(DXVO.ShapeDefaults openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FillColor);
  }
  
  private static bool CmpFillColor(DXVO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FillColor, value, diffs, objName, "FillColor");
  }
  
  private static void SetFillColor(DXVO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.FillColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  private static Boolean? GetIsStroke(DXVO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.IsStroke?.Value;
  }
  
  private static bool CmpIsStroke(DXVO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsStroke?.Value == value) return true;
    diffs?.Add(objName, "IsStroke", openXmlElement?.IsStroke?.Value, value);
    return false;
  }
  
  private static void SetIsStroke(DXVO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsStroke = value;
    else
      openXmlElement.IsStroke = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  private static String? GetStrokeColor(DXVO.ShapeDefaults openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StrokeColor);
  }
  
  private static bool CmpStrokeColor(DXVO.ShapeDefaults openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StrokeColor, value, diffs, objName, "StrokeColor");
  }
  
  private static void SetStrokeColor(DXVO.ShapeDefaults openXmlElement, String? value)
  {
    openXmlElement.StrokeColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  private static Boolean? GetAllowInCell(DXVO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  private static bool CmpAllowInCell(DXVO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowInCell?.Value == value) return true;
    diffs?.Add(objName, "AllowInCell", openXmlElement?.AllowInCell?.Value, value);
    return false;
  }
  
  private static void SetAllowInCell(DXVO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInCell = value;
    else
      openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  private static Boolean? GetAllowOverlap(DXVO.ShapeDefaults openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  private static bool CmpAllowOverlap(DXVO.ShapeDefaults openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AllowOverlap?.Value == value) return true;
    diffs?.Add(objName, "AllowOverlap", openXmlElement?.AllowOverlap?.Value, value);
    return false;
  }
  
  private static void SetAllowOverlap(DXVO.ShapeDefaults openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowOverlap = value;
    else
      openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  private static DMV.InsetMarginKind? GetInsetMode(DXVO.ShapeDefaults openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  private static bool CmpInsetMode(DXVO.ShapeDefaults openXmlElement, DMV.InsetMarginKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(openXmlElement?.InsetMode?.Value, value, diffs, objName);
  }
  
  private static void SetInsetMode(DXVO.ShapeDefaults openXmlElement, DMV.InsetMarginKind? value)
  {
    openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DMV.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  private static DMV.Fill? GetFill(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Fill>();
    if (element != null)
      return DMXV.FillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFill(DXVO.ShapeDefaults openXmlElement, DMV.Fill? value, DiffList? diffs, string? objName)
  {
    return DMXV.FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Fill>(), value, diffs, objName);
  }
  
  private static void SetFill(DXVO.ShapeDefaults openXmlElement, DMV.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Fill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  private static DMV.ImageData? GetImageData(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.ImageData>();
    if (element != null)
      return DMXV.ImageDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageData(DXVO.ShapeDefaults openXmlElement, DMV.ImageData? value, DiffList? diffs, string? objName)
  {
    return DMXV.ImageDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.ImageData>(), value, diffs, objName);
  }
  
  private static void SetImageData(DXVO.ShapeDefaults openXmlElement, DMV.ImageData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.ImageData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ImageDataConverter.CreateOpenXmlElement<DXV.ImageData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  private static DMV.Stroke? GetStroke(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Stroke>();
    if (element != null)
      return DMXV.StrokeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStroke(DXVO.ShapeDefaults openXmlElement, DMV.Stroke? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Stroke>(), value, diffs, objName);
  }
  
  private static void SetStroke(DXVO.ShapeDefaults openXmlElement, DMV.Stroke? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Stroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeConverter.CreateOpenXmlElement<DXV.Stroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  private static DMV.TextBox? GetTextBox(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.TextBox>();
    if (element != null)
      return DMXV.TextBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBox(DXVO.ShapeDefaults openXmlElement, DMV.TextBox? value, DiffList? diffs, string? objName)
  {
    return DMXV.TextBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.TextBox>(), value, diffs, objName);
  }
  
  private static void SetTextBox(DXVO.ShapeDefaults openXmlElement, DMV.TextBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.TextBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.TextBoxConverter.CreateOpenXmlElement<DXV.TextBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  private static DMV.Shadow? GetShadow(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXV.Shadow>();
    if (element != null)
      return DMXV.ShadowConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShadow(DXVO.ShapeDefaults openXmlElement, DMV.Shadow? value, DiffList? diffs, string? objName)
  {
    return DMXV.ShadowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXV.Shadow>(), value, diffs, objName);
  }
  
  private static void SetShadow(DXVO.ShapeDefaults openXmlElement, DMV.Shadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXV.Shadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShadowConverter.CreateOpenXmlElement<DXV.Shadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  private static DMV.Skew? GetSkew(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Skew>();
    if (element != null)
      return DMXV.SkewConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSkew(DXVO.ShapeDefaults openXmlElement, DMV.Skew? value, DiffList? diffs, string? objName)
  {
    return DMXV.SkewConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Skew>(), value, diffs, objName);
  }
  
  private static void SetSkew(DXVO.ShapeDefaults openXmlElement, DMV.Skew? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Skew>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.SkewConverter.CreateOpenXmlElement<DXVO.Skew>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  private static DMV.Extrusion? GetExtrusion(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Extrusion>();
    if (element != null)
      return DMXV.ExtrusionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusion(DXVO.ShapeDefaults openXmlElement, DMV.Extrusion? value, DiffList? diffs, string? objName)
  {
    return DMXV.ExtrusionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Extrusion>(), value, diffs, objName);
  }
  
  private static void SetExtrusion(DXVO.ShapeDefaults openXmlElement, DMV.Extrusion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Extrusion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ExtrusionConverter.CreateOpenXmlElement<DXVO.Extrusion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  private static DMV.Callout? GetCallout(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Callout>();
    if (element != null)
      return DMXV.CalloutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCallout(DXVO.ShapeDefaults openXmlElement, DMV.Callout? value, DiffList? diffs, string? objName)
  {
    return DMXV.CalloutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Callout>(), value, diffs, objName);
  }
  
  private static void SetCallout(DXVO.ShapeDefaults openXmlElement, DMV.Callout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Callout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.CalloutConverter.CreateOpenXmlElement<DXVO.Callout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  private static DMV.Lock? GetLock(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Lock>();
    if (element != null)
      return DMXV.LockConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLock(DXVO.ShapeDefaults openXmlElement, DMV.Lock? value, DiffList? diffs, string? objName)
  {
    return DMXV.LockConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Lock>(), value, diffs, objName);
  }
  
  private static void SetLock(DXVO.ShapeDefaults openXmlElement, DMV.Lock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.LockConverter.CreateOpenXmlElement<DXVO.Lock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  private static DMV.ColorMostRecentlyUsed? GetColorMostRecentlyUsed(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ColorMostRecentlyUsed>();
    if (element != null)
      return DMXV.ColorMostRecentlyUsedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMostRecentlyUsed(DXVO.ShapeDefaults openXmlElement, DMV.ColorMostRecentlyUsed? value, DiffList? diffs, string? objName)
  {
    return DMXV.ColorMostRecentlyUsedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ColorMostRecentlyUsed>(), value, diffs, objName);
  }
  
  private static void SetColorMostRecentlyUsed(DXVO.ShapeDefaults openXmlElement, DMV.ColorMostRecentlyUsed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ColorMostRecentlyUsed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ColorMostRecentlyUsedConverter.CreateOpenXmlElement<DXVO.ColorMostRecentlyUsed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  private static DMV.ColorMenu? GetColorMenu(DXVO.ShapeDefaults openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ColorMenu>();
    if (element != null)
      return DMXV.ColorMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMenu(DXVO.ShapeDefaults openXmlElement, DMV.ColorMenu? value, DiffList? diffs, string? objName)
  {
    return DMXV.ColorMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ColorMenu>(), value, diffs, objName);
  }
  
  private static void SetColorMenu(DXVO.ShapeDefaults openXmlElement, DMV.ColorMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ColorMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ColorMenuConverter.CreateOpenXmlElement<DXVO.ColorMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.ShapeDefaults? CreateModelElement(DXVO.ShapeDefaults? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.ShapeDefaults? openXmlElement, DMV.ShapeDefaults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.ShapeDefaults value)
    where OpenXmlElementType: DXVO.ShapeDefaults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.ShapeDefaults openXmlElement, DMV.ShapeDefaults value)
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
