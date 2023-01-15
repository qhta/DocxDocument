using DocumentFormat.OpenXml.Drawing.Diagrams;
using PresentationLayoutVariables = DocumentModel.Drawings.Diagrams.PresentationLayoutVariables;
using Style = DocumentModel.Drawings.Diagrams.Style;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Property Set.
/// </summary>
public static class PropertySetConverter
{
  /// <summary>
  ///   Presentation Element Identifier
  /// </summary>
  public static String? GetPresentationElementId(PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationElementId?.Value;
  }

  public static void SetPresentationElementId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationElementId = new StringValue { Value = value };
      else
        openXmlElement.PresentationElementId = null;
  }

  /// <summary>
  ///   Presentation Name
  /// </summary>
  public static String? GetPresentationName(PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationName?.Value;
  }

  public static void SetPresentationName(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationName = new StringValue { Value = value };
      else
        openXmlElement.PresentationName = null;
  }

  /// <summary>
  ///   Presentation Style Label
  /// </summary>
  public static String? GetPresentationStyleLabel(PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleLabel?.Value;
  }

  public static void SetPresentationStyleLabel(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PresentationStyleLabel = new StringValue { Value = value };
      else
        openXmlElement.PresentationStyleLabel = null;
  }

  /// <summary>
  ///   Presentation Style Index
  /// </summary>
  public static Int32? GetPresentationStyleIndex(PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleIndex?.Value;
  }

  public static void SetPresentationStyleIndex(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresentationStyleIndex = value;
  }

  /// <summary>
  ///   Presentation Style Count
  /// </summary>
  public static Int32? GetPresentationStyleCount(PropertySet? openXmlElement)
  {
    return openXmlElement?.PresentationStyleCount?.Value;
  }

  public static void SetPresentationStyleCount(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresentationStyleCount = value;
  }

  /// <summary>
  ///   Current Diagram Type
  /// </summary>
  public static String? GetLayoutTypeId(PropertySet? openXmlElement)
  {
    return openXmlElement?.LayoutTypeId?.Value;
  }

  public static void SetLayoutTypeId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutTypeId = new StringValue { Value = value };
      else
        openXmlElement.LayoutTypeId = null;
  }

  /// <summary>
  ///   Current Diagram Category
  /// </summary>
  public static String? GetLayoutCategoryId(PropertySet? openXmlElement)
  {
    return openXmlElement?.LayoutCategoryId?.Value;
  }

  public static void SetLayoutCategoryId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LayoutCategoryId = new StringValue { Value = value };
      else
        openXmlElement.LayoutCategoryId = null;
  }

  /// <summary>
  ///   Current Style Type
  /// </summary>
  public static String? GetQuickStyleTypeId(PropertySet? openXmlElement)
  {
    return openXmlElement?.QuickStyleTypeId?.Value;
  }

  public static void SetQuickStyleTypeId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QuickStyleTypeId = new StringValue { Value = value };
      else
        openXmlElement.QuickStyleTypeId = null;
  }

  /// <summary>
  ///   Current Style Category
  /// </summary>
  public static String? GetQuickStyleCategoryId(PropertySet? openXmlElement)
  {
    return openXmlElement?.QuickStyleCategoryId?.Value;
  }

  public static void SetQuickStyleCategoryId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QuickStyleCategoryId = new StringValue { Value = value };
      else
        openXmlElement.QuickStyleCategoryId = null;
  }

  /// <summary>
  ///   Color Transform Type Identifier
  /// </summary>
  public static String? GetColorType(PropertySet? openXmlElement)
  {
    return openXmlElement?.ColorType?.Value;
  }

  public static void SetColorType(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ColorType = new StringValue { Value = value };
      else
        openXmlElement.ColorType = null;
  }

  /// <summary>
  ///   Color Transform Category
  /// </summary>
  public static String? GetColorCategoryId(PropertySet? openXmlElement)
  {
    return openXmlElement?.ColorCategoryId?.Value;
  }

  public static void SetColorCategoryId(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ColorCategoryId = new StringValue { Value = value };
      else
        openXmlElement.ColorCategoryId = null;
  }

  /// <summary>
  ///   Coherent 3D Behavior
  /// </summary>
  public static Boolean? GetCoherent3D(PropertySet? openXmlElement)
  {
    return openXmlElement?.Coherent3D?.Value;
  }

  public static void SetCoherent3D(PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Coherent3D = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Coherent3D = null;
  }

  /// <summary>
  ///   Placeholder Text
  /// </summary>
  public static String? GetPlaceholderText(PropertySet? openXmlElement)
  {
    return openXmlElement?.PlaceholderText?.Value;
  }

  public static void SetPlaceholderText(PropertySet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PlaceholderText = new StringValue { Value = value };
      else
        openXmlElement.PlaceholderText = null;
  }

  /// <summary>
  ///   Placeholder
  /// </summary>
  public static Boolean? GetPlaceholder(PropertySet? openXmlElement)
  {
    return openXmlElement?.Placeholder?.Value;
  }

  public static void SetPlaceholder(PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Placeholder = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Placeholder = null;
  }

  /// <summary>
  ///   Custom Rotation
  /// </summary>
  public static Int32? GetRotation(PropertySet? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }

  public static void SetRotation(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }

  /// <summary>
  ///   Custom Vertical Flip
  /// </summary>
  public static Boolean? GetVerticalFlip(PropertySet? openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }

  public static void SetVerticalFlip(PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.VerticalFlip = null;
  }

  /// <summary>
  ///   Custom Horizontal Flip
  /// </summary>
  public static Boolean? GetHorizontalFlip(PropertySet? openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }

  public static void SetHorizontalFlip(PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HorizontalFlip = null;
  }

  /// <summary>
  ///   Fixed Width Override
  /// </summary>
  public static Int32? GetFixedWidthOverride(PropertySet? openXmlElement)
  {
    return openXmlElement?.FixedWidthOverride?.Value;
  }

  public static void SetFixedWidthOverride(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FixedWidthOverride = value;
  }

  /// <summary>
  ///   Fixed Height Override
  /// </summary>
  public static Int32? GetFixedHeightOverride(PropertySet? openXmlElement)
  {
    return openXmlElement?.FixedHeightOverride?.Value;
  }

  public static void SetFixedHeightOverride(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FixedHeightOverride = value;
  }

  /// <summary>
  ///   Width Scale
  /// </summary>
  public static Int32? GetWidthScale(PropertySet? openXmlElement)
  {
    return openXmlElement?.WidthScale?.Value;
  }

  public static void SetWidthScale(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.WidthScale = value;
  }

  /// <summary>
  ///   Height Scale
  /// </summary>
  public static Int32? GetHightScale(PropertySet? openXmlElement)
  {
    return openXmlElement?.HightScale?.Value;
  }

  public static void SetHightScale(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HightScale = value;
  }

  /// <summary>
  ///   Text Changed
  /// </summary>
  public static Boolean? GetTextChanged(PropertySet? openXmlElement)
  {
    return openXmlElement?.TextChanged?.Value;
  }

  public static void SetTextChanged(PropertySet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextChanged = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.TextChanged = null;
  }

  /// <summary>
  ///   Custom Factor Width
  /// </summary>
  public static Int32? GetFactorWidth(PropertySet? openXmlElement)
  {
    return openXmlElement?.FactorWidth?.Value;
  }

  public static void SetFactorWidth(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FactorWidth = value;
  }

  /// <summary>
  ///   Custom Factor Height
  /// </summary>
  public static Int32? GetFactorHeight(PropertySet? openXmlElement)
  {
    return openXmlElement?.FactorHeight?.Value;
  }

  public static void SetFactorHeight(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FactorHeight = value;
  }

  /// <summary>
  ///   Neighbor Offset Width
  /// </summary>
  public static Int32? GetNeighborOffsetWidth(PropertySet? openXmlElement)
  {
    return openXmlElement?.NeighborOffsetWidth?.Value;
  }

  public static void SetNeighborOffsetWidth(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NeighborOffsetWidth = value;
  }

  /// <summary>
  ///   Neighbor Offset Height
  /// </summary>
  public static Int32? GetNeighborOffsetHeight(PropertySet? openXmlElement)
  {
    return openXmlElement?.NeighborOffsetHeight?.Value;
  }

  public static void SetNeighborOffsetHeight(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.NeighborOffsetHeight = value;
  }

  /// <summary>
  ///   Radius Scale
  /// </summary>
  public static Int32? GetRadiusScale(PropertySet? openXmlElement)
  {
    return openXmlElement?.RadiusScale?.Value;
  }

  public static void SetRadiusScale(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RadiusScale = value;
  }

  /// <summary>
  ///   Include Angle Scale
  /// </summary>
  public static Int32? GetIncludeAngleScale(PropertySet? openXmlElement)
  {
    return openXmlElement?.IncludeAngleScale?.Value;
  }

  public static void SetIncludeAngleScale(PropertySet? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.IncludeAngleScale = value;
  }

  /// <summary>
  ///   Presentation Layout Variables.
  /// </summary>
  public static PresentationLayoutVariables? GetPresentationLayoutVariables(PropertySet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
    if (itemElement != null)
      return PresentationLayoutVariablesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresentationLayoutVariables(PropertySet? openXmlElement, PresentationLayoutVariables? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresentationLayoutVariablesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Style.
  /// </summary>
  public static Style? GetStyle(PropertySet? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
    if (itemElement != null)
      return StyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyle(PropertySet? openXmlElement, Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.PropertySet? CreateModelElement(PropertySet? openXmlElement)
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
    where OpenXmlElementType : PropertySet, new()
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