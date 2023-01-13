namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public static class ShapeDefaultsConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public static Int64? GetMaxShapeId(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.MaxShapeId?.Value;
  }
  
  public static void SetMaxShapeId(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.MaxShapeId = value;
  }
  
  /// <summary>
  /// style
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetBeFilled(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.BeFilled?.Value;
  }
  
  public static void SetBeFilled(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BeFilled = value;
      else
        openXmlElement.BeFilled = null;
  }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public static String? GetFillColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.FillColor?.Value;
  }
  
  public static void SetFillColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FillColor = new StringValue { Value = value };
      else
        openXmlElement.FillColor = null;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public static Boolean? GetIsStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.IsStroke?.Value;
  }
  
  public static void SetIsStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsStroke = value;
      else
        openXmlElement.IsStroke = null;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public static String? GetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.StrokeColor?.Value;
  }
  
  public static void SetStrokeColor(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StrokeColor = new StringValue { Value = value };
      else
        openXmlElement.StrokeColor = null;
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.AllowInCell?.Value;
  }
  
  public static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInCell = value;
      else
        openXmlElement.AllowInCell = null;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return openXmlElement?.AllowOverlap?.Value;
  }
  
  public static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowOverlap = value;
      else
        openXmlElement.AllowOverlap = null;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  public static void SetInsetMode(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.FillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Fill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.FillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Fill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public static DocumentModel.Vml.ImageData? GetImageData(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageData(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ImageData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ImageDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public static DocumentModel.Vml.Stroke? GetStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStroke(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Stroke? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.StrokeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Stroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public static DocumentModel.Vml.TextBox? GetTextBox(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.TextBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBox(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.TextBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.TextBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.TextBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public static DocumentModel.Vml.Shadow? GetShadow(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShadow(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Shadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public static DocumentModel.Vml.Skew? GetSkew(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.SkewConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSkew(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Skew? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.SkewConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Skew>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public static DocumentModel.Vml.Extrusion? GetExtrusion(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ExtrusionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtrusion(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Extrusion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ExtrusionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Extrusion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public static DocumentModel.Vml.Callout? GetCallout(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CalloutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCallout(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Callout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.CalloutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Callout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.Lock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.LockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Lock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public static DocumentModel.Vml.ColorMostRecentlyUsed? GetColorMostRecentlyUsed(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ColorMostRecentlyUsedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorMostRecentlyUsed(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ColorMostRecentlyUsed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ColorMostRecentlyUsedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public static DocumentModel.Vml.ColorMenu? GetColorMenu(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ColorMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorMenu(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement, DocumentModel.Vml.ColorMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ColorMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ColorMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ShapeDefaults? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ShapeDefaults, new()
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
