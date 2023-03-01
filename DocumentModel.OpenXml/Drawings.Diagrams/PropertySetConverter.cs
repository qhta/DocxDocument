namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Property Set.
/// </summary>
public static class PropertySetConverter
{
  /// <summary>
  /// Presentation Element Identifier
  /// </summary>
  private static String? GetPresentationElementId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PresentationElementId);
  }
  
  private static bool CmpPresentationElementId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PresentationElementId, value, diffs, objName, "PresentationElementId");
  }
  
  private static void SetPresentationElementId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.PresentationElementId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Presentation Name
  /// </summary>
  private static String? GetPresentationName(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PresentationName);
  }
  
  private static bool CmpPresentationName(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PresentationName, value, diffs, objName, "PresentationName");
  }
  
  private static void SetPresentationName(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.PresentationName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Presentation Style Label
  /// </summary>
  private static String? GetPresentationStyleLabel(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PresentationStyleLabel);
  }
  
  private static bool CmpPresentationStyleLabel(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PresentationStyleLabel, value, diffs, objName, "PresentationStyleLabel");
  }
  
  private static void SetPresentationStyleLabel(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.PresentationStyleLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Presentation Style Index
  /// </summary>
  private static Int32? GetPresentationStyleIndex(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.PresentationStyleIndex?.Value;
  }
  
  private static bool CmpPresentationStyleIndex(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PresentationStyleIndex?.Value == value) return true;
    diffs?.Add(objName, "PresentationStyleIndex", openXmlElement?.PresentationStyleIndex?.Value, value);
    return false;
  }
  
  private static void SetPresentationStyleIndex(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.PresentationStyleIndex = value;
  }
  
  /// <summary>
  /// Presentation Style Count
  /// </summary>
  private static Int32? GetPresentationStyleCount(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.PresentationStyleCount?.Value;
  }
  
  private static bool CmpPresentationStyleCount(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PresentationStyleCount?.Value == value) return true;
    diffs?.Add(objName, "PresentationStyleCount", openXmlElement?.PresentationStyleCount?.Value, value);
    return false;
  }
  
  private static void SetPresentationStyleCount(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.PresentationStyleCount = value;
  }
  
  /// <summary>
  /// Current Diagram Type
  /// </summary>
  private static String? GetLayoutTypeId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LayoutTypeId);
  }
  
  private static bool CmpLayoutTypeId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LayoutTypeId, value, diffs, objName, "LayoutTypeId");
  }
  
  private static void SetLayoutTypeId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.LayoutTypeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Current Diagram Category
  /// </summary>
  private static String? GetLayoutCategoryId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LayoutCategoryId);
  }
  
  private static bool CmpLayoutCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LayoutCategoryId, value, diffs, objName, "LayoutCategoryId");
  }
  
  private static void SetLayoutCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.LayoutCategoryId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Current Style Type
  /// </summary>
  private static String? GetQuickStyleTypeId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QuickStyleTypeId);
  }
  
  private static bool CmpQuickStyleTypeId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QuickStyleTypeId, value, diffs, objName, "QuickStyleTypeId");
  }
  
  private static void SetQuickStyleTypeId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.QuickStyleTypeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Current Style Category
  /// </summary>
  private static String? GetQuickStyleCategoryId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QuickStyleCategoryId);
  }
  
  private static bool CmpQuickStyleCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QuickStyleCategoryId, value, diffs, objName, "QuickStyleCategoryId");
  }
  
  private static void SetQuickStyleCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.QuickStyleCategoryId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Color Transform Type Identifier
  /// </summary>
  private static String? GetColorType(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ColorType);
  }
  
  private static bool CmpColorType(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ColorType, value, diffs, objName, "ColorType");
  }
  
  private static void SetColorType(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.ColorType = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Color Transform Category
  /// </summary>
  private static String? GetColorCategoryId(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ColorCategoryId);
  }
  
  private static bool CmpColorCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ColorCategoryId, value, diffs, objName, "ColorCategoryId");
  }
  
  private static void SetColorCategoryId(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.ColorCategoryId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Coherent 3D Behavior
  /// </summary>
  private static Boolean? GetCoherent3D(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.Coherent3D?.Value;
  }
  
  private static bool CmpCoherent3D(DXDrawDgms.PropertySet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Coherent3D?.Value == value) return true;
    diffs?.Add(objName, "Coherent3D", openXmlElement?.Coherent3D?.Value, value);
    return false;
  }
  
  private static void SetCoherent3D(DXDrawDgms.PropertySet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Coherent3D = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Coherent3D = null;
  }
  
  /// <summary>
  /// Placeholder Text
  /// </summary>
  private static String? GetPlaceholderText(DXDrawDgms.PropertySet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PlaceholderText);
  }
  
  private static bool CmpPlaceholderText(DXDrawDgms.PropertySet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PlaceholderText, value, diffs, objName, "PlaceholderText");
  }
  
  private static void SetPlaceholderText(DXDrawDgms.PropertySet openXmlElement, String? value)
  {
    openXmlElement.PlaceholderText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Placeholder
  /// </summary>
  private static Boolean? GetPlaceholder(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.Placeholder?.Value;
  }
  
  private static bool CmpPlaceholder(DXDrawDgms.PropertySet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Placeholder?.Value == value) return true;
    diffs?.Add(objName, "Placeholder", openXmlElement?.Placeholder?.Value, value);
    return false;
  }
  
  private static void SetPlaceholder(DXDrawDgms.PropertySet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Placeholder = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Placeholder = null;
  }
  
  /// <summary>
  /// Custom Rotation
  /// </summary>
  private static Int32? GetRotation(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Custom Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static bool CmpVerticalFlip(DXDrawDgms.PropertySet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalFlip?.Value == value) return true;
    diffs?.Add(objName, "VerticalFlip", openXmlElement?.VerticalFlip?.Value, value);
    return false;
  }
  
  private static void SetVerticalFlip(DXDrawDgms.PropertySet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Custom Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static bool CmpHorizontalFlip(DXDrawDgms.PropertySet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalFlip?.Value == value) return true;
    diffs?.Add(objName, "HorizontalFlip", openXmlElement?.HorizontalFlip?.Value, value);
    return false;
  }
  
  private static void SetHorizontalFlip(DXDrawDgms.PropertySet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Fixed Width Override
  /// </summary>
  private static Int32? GetFixedWidthOverride(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.FixedWidthOverride?.Value;
  }
  
  private static bool CmpFixedWidthOverride(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FixedWidthOverride?.Value == value) return true;
    diffs?.Add(objName, "FixedWidthOverride", openXmlElement?.FixedWidthOverride?.Value, value);
    return false;
  }
  
  private static void SetFixedWidthOverride(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.FixedWidthOverride = value;
  }
  
  /// <summary>
  /// Fixed Height Override
  /// </summary>
  private static Int32? GetFixedHeightOverride(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.FixedHeightOverride?.Value;
  }
  
  private static bool CmpFixedHeightOverride(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FixedHeightOverride?.Value == value) return true;
    diffs?.Add(objName, "FixedHeightOverride", openXmlElement?.FixedHeightOverride?.Value, value);
    return false;
  }
  
  private static void SetFixedHeightOverride(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.FixedHeightOverride = value;
  }
  
  /// <summary>
  /// Width Scale
  /// </summary>
  private static Int32? GetWidthScale(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.WidthScale?.Value;
  }
  
  private static bool CmpWidthScale(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.WidthScale?.Value == value) return true;
    diffs?.Add(objName, "WidthScale", openXmlElement?.WidthScale?.Value, value);
    return false;
  }
  
  private static void SetWidthScale(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.WidthScale = value;
  }
  
  /// <summary>
  /// Height Scale
  /// </summary>
  private static Int32? GetHightScale(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.HightScale?.Value;
  }
  
  private static bool CmpHightScale(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HightScale?.Value == value) return true;
    diffs?.Add(objName, "HightScale", openXmlElement?.HightScale?.Value, value);
    return false;
  }
  
  private static void SetHightScale(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.HightScale = value;
  }
  
  /// <summary>
  /// Text Changed
  /// </summary>
  private static Boolean? GetTextChanged(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.TextChanged?.Value;
  }
  
  private static bool CmpTextChanged(DXDrawDgms.PropertySet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TextChanged?.Value == value) return true;
    diffs?.Add(objName, "TextChanged", openXmlElement?.TextChanged?.Value, value);
    return false;
  }
  
  private static void SetTextChanged(DXDrawDgms.PropertySet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextChanged = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextChanged = null;
  }
  
  /// <summary>
  /// Custom Factor Width
  /// </summary>
  private static Int32? GetFactorWidth(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.FactorWidth?.Value;
  }
  
  private static bool CmpFactorWidth(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FactorWidth?.Value == value) return true;
    diffs?.Add(objName, "FactorWidth", openXmlElement?.FactorWidth?.Value, value);
    return false;
  }
  
  private static void SetFactorWidth(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.FactorWidth = value;
  }
  
  /// <summary>
  /// Custom Factor Height
  /// </summary>
  private static Int32? GetFactorHeight(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.FactorHeight?.Value;
  }
  
  private static bool CmpFactorHeight(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FactorHeight?.Value == value) return true;
    diffs?.Add(objName, "FactorHeight", openXmlElement?.FactorHeight?.Value, value);
    return false;
  }
  
  private static void SetFactorHeight(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.FactorHeight = value;
  }
  
  /// <summary>
  /// Neighbor Offset Width
  /// </summary>
  private static Int32? GetNeighborOffsetWidth(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.NeighborOffsetWidth?.Value;
  }
  
  private static bool CmpNeighborOffsetWidth(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NeighborOffsetWidth?.Value == value) return true;
    diffs?.Add(objName, "NeighborOffsetWidth", openXmlElement?.NeighborOffsetWidth?.Value, value);
    return false;
  }
  
  private static void SetNeighborOffsetWidth(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.NeighborOffsetWidth = value;
  }
  
  /// <summary>
  /// Neighbor Offset Height
  /// </summary>
  private static Int32? GetNeighborOffsetHeight(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.NeighborOffsetHeight?.Value;
  }
  
  private static bool CmpNeighborOffsetHeight(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NeighborOffsetHeight?.Value == value) return true;
    diffs?.Add(objName, "NeighborOffsetHeight", openXmlElement?.NeighborOffsetHeight?.Value, value);
    return false;
  }
  
  private static void SetNeighborOffsetHeight(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.NeighborOffsetHeight = value;
  }
  
  /// <summary>
  /// Radius Scale
  /// </summary>
  private static Int32? GetRadiusScale(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.RadiusScale?.Value;
  }
  
  private static bool CmpRadiusScale(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RadiusScale?.Value == value) return true;
    diffs?.Add(objName, "RadiusScale", openXmlElement?.RadiusScale?.Value, value);
    return false;
  }
  
  private static void SetRadiusScale(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.RadiusScale = value;
  }
  
  /// <summary>
  /// Include Angle Scale
  /// </summary>
  private static Int32? GetIncludeAngleScale(DXDrawDgms.PropertySet openXmlElement)
  {
    return openXmlElement?.IncludeAngleScale?.Value;
  }
  
  private static bool CmpIncludeAngleScale(DXDrawDgms.PropertySet openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IncludeAngleScale?.Value == value) return true;
    diffs?.Add(objName, "IncludeAngleScale", openXmlElement?.IncludeAngleScale?.Value, value);
    return false;
  }
  
  private static void SetIncludeAngleScale(DXDrawDgms.PropertySet openXmlElement, Int32? value)
  {
    openXmlElement.IncludeAngleScale = value;
  }
  
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  private static DMDrawsDgms.PresentationLayoutVariables? GetPresentationLayoutVariables(DXDrawDgms.PropertySet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationLayoutVariables>();
    if (element != null)
      return DMXDrawsDgms.PresentationLayoutVariablesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresentationLayoutVariables(DXDrawDgms.PropertySet openXmlElement, DMDrawsDgms.PresentationLayoutVariables? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PresentationLayoutVariablesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PresentationLayoutVariables>(), value, diffs, objName);
  }
  
  private static void SetPresentationLayoutVariables(DXDrawDgms.PropertySet openXmlElement, DMDrawsDgms.PresentationLayoutVariables? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PresentationLayoutVariables>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.PresentationLayoutVariablesConverter.CreateOpenXmlElement<DXDrawDgms.PresentationLayoutVariables>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  private static DMDrawsDgms.Style? GetStyle(DXDrawDgms.PropertySet openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Style>();
    if (element != null)
      return DMXDrawsDgms.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDrawDgms.PropertySet openXmlElement, DMDrawsDgms.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Style>(), value, diffs, objName);
  }
  
  private static void SetStyle(DXDrawDgms.PropertySet openXmlElement, DMDrawsDgms.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleConverter.CreateOpenXmlElement<DXDrawDgms.Style>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PropertySet? CreateModelElement(DXDrawDgms.PropertySet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PropertySet();
      value.PresentationElementId = GetPresentationElementId(openXmlElement);
      value.PresentationName = GetPresentationName(openXmlElement);
      value.PresentationStyleLabel = GetPresentationStyleLabel(openXmlElement);
      value.PresentationStyleIndex = GetPresentationStyleIndex(openXmlElement);
      value.PresentationStyleCount = GetPresentationStyleCount(openXmlElement);
      value.LayoutTypeId = GetLayoutTypeId(openXmlElement);
      value.LayoutCategoryId = GetLayoutCategoryId(openXmlElement);
      value.QuickStyleTypeId = GetQuickStyleTypeId(openXmlElement);
      value.QuickStyleCategoryId = GetQuickStyleCategoryId(openXmlElement);
      value.ColorType = GetColorType(openXmlElement);
      value.ColorCategoryId = GetColorCategoryId(openXmlElement);
      value.Coherent3D = GetCoherent3D(openXmlElement);
      value.PlaceholderText = GetPlaceholderText(openXmlElement);
      value.Placeholder = GetPlaceholder(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.FixedWidthOverride = GetFixedWidthOverride(openXmlElement);
      value.FixedHeightOverride = GetFixedHeightOverride(openXmlElement);
      value.WidthScale = GetWidthScale(openXmlElement);
      value.HightScale = GetHightScale(openXmlElement);
      value.TextChanged = GetTextChanged(openXmlElement);
      value.FactorWidth = GetFactorWidth(openXmlElement);
      value.FactorHeight = GetFactorHeight(openXmlElement);
      value.NeighborOffsetWidth = GetNeighborOffsetWidth(openXmlElement);
      value.NeighborOffsetHeight = GetNeighborOffsetHeight(openXmlElement);
      value.RadiusScale = GetRadiusScale(openXmlElement);
      value.IncludeAngleScale = GetIncludeAngleScale(openXmlElement);
      value.PresentationLayoutVariables = GetPresentationLayoutVariables(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.PropertySet? openXmlElement, DMDrawsDgms.PropertySet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPresentationElementId(openXmlElement, value.PresentationElementId, diffs, objName))
        ok = false;
      if (!CmpPresentationName(openXmlElement, value.PresentationName, diffs, objName))
        ok = false;
      if (!CmpPresentationStyleLabel(openXmlElement, value.PresentationStyleLabel, diffs, objName))
        ok = false;
      if (!CmpPresentationStyleIndex(openXmlElement, value.PresentationStyleIndex, diffs, objName))
        ok = false;
      if (!CmpPresentationStyleCount(openXmlElement, value.PresentationStyleCount, diffs, objName))
        ok = false;
      if (!CmpLayoutTypeId(openXmlElement, value.LayoutTypeId, diffs, objName))
        ok = false;
      if (!CmpLayoutCategoryId(openXmlElement, value.LayoutCategoryId, diffs, objName))
        ok = false;
      if (!CmpQuickStyleTypeId(openXmlElement, value.QuickStyleTypeId, diffs, objName))
        ok = false;
      if (!CmpQuickStyleCategoryId(openXmlElement, value.QuickStyleCategoryId, diffs, objName))
        ok = false;
      if (!CmpColorType(openXmlElement, value.ColorType, diffs, objName))
        ok = false;
      if (!CmpColorCategoryId(openXmlElement, value.ColorCategoryId, diffs, objName))
        ok = false;
      if (!CmpCoherent3D(openXmlElement, value.Coherent3D, diffs, objName))
        ok = false;
      if (!CmpPlaceholderText(openXmlElement, value.PlaceholderText, diffs, objName))
        ok = false;
      if (!CmpPlaceholder(openXmlElement, value.Placeholder, diffs, objName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      if (!CmpVerticalFlip(openXmlElement, value.VerticalFlip, diffs, objName))
        ok = false;
      if (!CmpHorizontalFlip(openXmlElement, value.HorizontalFlip, diffs, objName))
        ok = false;
      if (!CmpFixedWidthOverride(openXmlElement, value.FixedWidthOverride, diffs, objName))
        ok = false;
      if (!CmpFixedHeightOverride(openXmlElement, value.FixedHeightOverride, diffs, objName))
        ok = false;
      if (!CmpWidthScale(openXmlElement, value.WidthScale, diffs, objName))
        ok = false;
      if (!CmpHightScale(openXmlElement, value.HightScale, diffs, objName))
        ok = false;
      if (!CmpTextChanged(openXmlElement, value.TextChanged, diffs, objName))
        ok = false;
      if (!CmpFactorWidth(openXmlElement, value.FactorWidth, diffs, objName))
        ok = false;
      if (!CmpFactorHeight(openXmlElement, value.FactorHeight, diffs, objName))
        ok = false;
      if (!CmpNeighborOffsetWidth(openXmlElement, value.NeighborOffsetWidth, diffs, objName))
        ok = false;
      if (!CmpNeighborOffsetHeight(openXmlElement, value.NeighborOffsetHeight, diffs, objName))
        ok = false;
      if (!CmpRadiusScale(openXmlElement, value.RadiusScale, diffs, objName))
        ok = false;
      if (!CmpIncludeAngleScale(openXmlElement, value.IncludeAngleScale, diffs, objName))
        ok = false;
      if (!CmpPresentationLayoutVariables(openXmlElement, value.PresentationLayoutVariables, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PropertySet value)
    where OpenXmlElementType: DXDrawDgms.PropertySet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.PropertySet openXmlElement, DMDrawsDgms.PropertySet value)
  {
    SetPresentationElementId(openXmlElement, value?.PresentationElementId);
    SetPresentationName(openXmlElement, value?.PresentationName);
    SetPresentationStyleLabel(openXmlElement, value?.PresentationStyleLabel);
    SetPresentationStyleIndex(openXmlElement, value?.PresentationStyleIndex);
    SetPresentationStyleCount(openXmlElement, value?.PresentationStyleCount);
    SetLayoutTypeId(openXmlElement, value?.LayoutTypeId);
    SetLayoutCategoryId(openXmlElement, value?.LayoutCategoryId);
    SetQuickStyleTypeId(openXmlElement, value?.QuickStyleTypeId);
    SetQuickStyleCategoryId(openXmlElement, value?.QuickStyleCategoryId);
    SetColorType(openXmlElement, value?.ColorType);
    SetColorCategoryId(openXmlElement, value?.ColorCategoryId);
    SetCoherent3D(openXmlElement, value?.Coherent3D);
    SetPlaceholderText(openXmlElement, value?.PlaceholderText);
    SetPlaceholder(openXmlElement, value?.Placeholder);
    SetRotation(openXmlElement, value?.Rotation);
    SetVerticalFlip(openXmlElement, value?.VerticalFlip);
    SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
    SetFixedWidthOverride(openXmlElement, value?.FixedWidthOverride);
    SetFixedHeightOverride(openXmlElement, value?.FixedHeightOverride);
    SetWidthScale(openXmlElement, value?.WidthScale);
    SetHightScale(openXmlElement, value?.HightScale);
    SetTextChanged(openXmlElement, value?.TextChanged);
    SetFactorWidth(openXmlElement, value?.FactorWidth);
    SetFactorHeight(openXmlElement, value?.FactorHeight);
    SetNeighborOffsetWidth(openXmlElement, value?.NeighborOffsetWidth);
    SetNeighborOffsetHeight(openXmlElement, value?.NeighborOffsetHeight);
    SetRadiusScale(openXmlElement, value?.RadiusScale);
    SetIncludeAngleScale(openXmlElement, value?.IncludeAngleScale);
    SetPresentationLayoutVariables(openXmlElement, value?.PresentationLayoutVariables);
    SetStyle(openXmlElement, value?.Style);
  }
}
