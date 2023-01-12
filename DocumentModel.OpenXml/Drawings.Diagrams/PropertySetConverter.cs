namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Property Set.
/// </summary>
public static class PropertySetConverter
{
  /// <summary>
  /// Presentation Element Identifier
  /// </summary>
  public static String? GetPresentationElementId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationElementId?.Value;
  }
  
  public static void SetPresentationElementId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationElementId = new StringValue { Value = value };
      else
        openXmlElement.PresentationElementId = null;
  }
  
  /// <summary>
  /// Presentation Name
  /// </summary>
  public static String? GetPresentationName(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationName?.Value;
  }
  
  public static void SetPresentationName(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationName = new StringValue { Value = value };
      else
        openXmlElement.PresentationName = null;
  }
  
  /// <summary>
  /// Presentation Style Label
  /// </summary>
  public static String? GetPresentationStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleLabel?.Value;
  }
  
  public static void SetPresentationStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationStyleLabel = new StringValue { Value = value };
      else
        openXmlElement.PresentationStyleLabel = null;
  }
  
  /// <summary>
  /// Presentation Style Index
  /// </summary>
  public static Int32? GetPresentationStyleIndex(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleIndex?.Value;
  }
  
  public static void SetPresentationStyleIndex(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresentationStyleIndex = value;
  }
  
  /// <summary>
  /// Presentation Style Count
  /// </summary>
  public static Int32? GetPresentationStyleCount(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleCount?.Value;
  }
  
  public static void SetPresentationStyleCount(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresentationStyleCount = value;
  }
  
  /// <summary>
  /// Current Diagram Type
  /// </summary>
  public static String? GetLayoutTypeId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.LayoutTypeId?.Value;
  }
  
  public static void SetLayoutTypeId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutTypeId = new StringValue { Value = value };
      else
        openXmlElement.LayoutTypeId = null;
  }
  
  /// <summary>
  /// Current Diagram Category
  /// </summary>
  public static String? GetLayoutCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.LayoutCategoryId?.Value;
  }
  
  public static void SetLayoutCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutCategoryId = new StringValue { Value = value };
      else
        openXmlElement.LayoutCategoryId = null;
  }
  
  /// <summary>
  /// Current Style Type
  /// </summary>
  public static String? GetQuickStyleTypeId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.QuickStyleTypeId?.Value;
  }
  
  public static void SetQuickStyleTypeId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QuickStyleTypeId = new StringValue { Value = value };
      else
        openXmlElement.QuickStyleTypeId = null;
  }
  
  /// <summary>
  /// Current Style Category
  /// </summary>
  public static String? GetQuickStyleCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.QuickStyleCategoryId?.Value;
  }
  
  public static void SetQuickStyleCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QuickStyleCategoryId = new StringValue { Value = value };
      else
        openXmlElement.QuickStyleCategoryId = null;
  }
  
  /// <summary>
  /// Color Transform Type Identifier
  /// </summary>
  public static String? GetColorType(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.ColorType?.Value;
  }
  
  public static void SetColorType(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ColorType = new StringValue { Value = value };
      else
        openXmlElement.ColorType = null;
  }
  
  /// <summary>
  /// Color Transform Category
  /// </summary>
  public static String? GetColorCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.ColorCategoryId?.Value;
  }
  
  public static void SetColorCategoryId(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ColorCategoryId = new StringValue { Value = value };
      else
        openXmlElement.ColorCategoryId = null;
  }
  
  /// <summary>
  /// Coherent 3D Behavior
  /// </summary>
  public static Boolean? GetCoherent3D(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.Coherent3D?.Value;
  }
  
  public static void SetCoherent3D(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Coherent3D = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Coherent3D = null;
  }
  
  /// <summary>
  /// Placeholder Text
  /// </summary>
  public static String? GetPlaceholderText(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.PlaceholderText?.Value;
  }
  
  public static void SetPlaceholderText(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PlaceholderText = new StringValue { Value = value };
      else
        openXmlElement.PlaceholderText = null;
  }
  
  /// <summary>
  /// Placeholder
  /// </summary>
  public static Boolean? GetPlaceholder(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.Placeholder?.Value;
  }
  
  public static void SetPlaceholder(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Placeholder = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Placeholder = null;
  }
  
  /// <summary>
  /// Custom Rotation
  /// </summary>
  public static Int32? GetRotation(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Custom Vertical Flip
  /// </summary>
  public static Boolean? GetVerticalFlip(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  public static void SetVerticalFlip(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Custom Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  public static void SetHorizontalFlip(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Fixed Width Override
  /// </summary>
  public static Int32? GetFixedWidthOverride(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.FixedWidthOverride?.Value;
  }
  
  public static void SetFixedWidthOverride(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FixedWidthOverride = value;
  }
  
  /// <summary>
  /// Fixed Height Override
  /// </summary>
  public static Int32? GetFixedHeightOverride(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.FixedHeightOverride?.Value;
  }
  
  public static void SetFixedHeightOverride(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FixedHeightOverride = value;
  }
  
  /// <summary>
  /// Width Scale
  /// </summary>
  public static Int32? GetWidthScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.WidthScale?.Value;
  }
  
  public static void SetWidthScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.WidthScale = value;
  }
  
  /// <summary>
  /// Height Scale
  /// </summary>
  public static Int32? GetHightScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.HightScale?.Value;
  }
  
  public static void SetHightScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HightScale = value;
  }
  
  /// <summary>
  /// Text Changed
  /// </summary>
  public static Boolean? GetTextChanged(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.TextChanged?.Value;
  }
  
  public static void SetTextChanged(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextChanged = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.TextChanged = null;
  }
  
  /// <summary>
  /// Custom Factor Width
  /// </summary>
  public static Int32? GetFactorWidth(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.FactorWidth?.Value;
  }
  
  public static void SetFactorWidth(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FactorWidth = value;
  }
  
  /// <summary>
  /// Custom Factor Height
  /// </summary>
  public static Int32? GetFactorHeight(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.FactorHeight?.Value;
  }
  
  public static void SetFactorHeight(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FactorHeight = value;
  }
  
  /// <summary>
  /// Neighbor Offset Width
  /// </summary>
  public static Int32? GetNeighborOffsetWidth(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.NeighborOffsetWidth?.Value;
  }
  
  public static void SetNeighborOffsetWidth(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NeighborOffsetWidth = value;
  }
  
  /// <summary>
  /// Neighbor Offset Height
  /// </summary>
  public static Int32? GetNeighborOffsetHeight(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.NeighborOffsetHeight?.Value;
  }
  
  public static void SetNeighborOffsetHeight(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NeighborOffsetHeight = value;
  }
  
  /// <summary>
  /// Radius Scale
  /// </summary>
  public static Int32? GetRadiusScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.RadiusScale?.Value;
  }
  
  public static void SetRadiusScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RadiusScale = value;
  }
  
  /// <summary>
  /// Include Angle Scale
  /// </summary>
  public static Int32? GetIncludeAngleScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    return openXmlElement?.IncludeAngleScale?.Value;
  }
  
  public static void SetIncludeAngleScale(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.IncludeAngleScale = value;
  }
  
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.PresentationLayoutVariables? GetPresentationLayoutVariables(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PresentationLayoutVariablesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresentationLayoutVariables(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, DocumentModel.Drawings.Diagrams.PresentationLayoutVariables? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PresentationLayoutVariablesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.Style? GetStyle(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement, DocumentModel.Drawings.Diagrams.Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PropertySet? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PropertySet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
