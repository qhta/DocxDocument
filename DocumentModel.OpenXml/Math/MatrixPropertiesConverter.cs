namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public static class MatrixPropertiesConverter
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  private static DMMath.VerticalAlignmentKind? GetBaseJustification(DXMath.MatrixProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.BaseJustification>()?.Val?.Value);
  }
  
  private static bool CmpBaseJustification(DXMath.MatrixProperties openXmlElement, DMMath.VerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXMath.BaseJustification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBaseJustification(DXMath.MatrixProperties openXmlElement, DMMath.VerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BaseJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMMath.VerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  private static DMMath.BooleanKind? GetHidePlaceholder(DXMath.MatrixProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HidePlaceholder>()?.Val?.Value);
  }
  
  private static bool CmpHidePlaceholder(DXMath.MatrixProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.HidePlaceholder>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHidePlaceholder(DXMath.MatrixProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HidePlaceholder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HidePlaceholder, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  private static Int64? GetRowSpacingRule(DXMath.MatrixProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.RowSpacingRule>()?.Val?.Value;
  }
  
  private static bool CmpRowSpacingRule(DXMath.MatrixProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacingRule>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.RowSpacingRule", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRowSpacingRule(DXMath.MatrixProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RowSpacingRule>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.RowSpacingRule{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Matrix Column Gap Rule.
  /// </summary>
  private static Int64? GetColumnGapRule(DXMath.MatrixProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.ColumnGapRule>()?.Val?.Value;
  }
  
  private static bool CmpColumnGapRule(DXMath.MatrixProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ColumnGapRule>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.ColumnGapRule", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetColumnGapRule(DXMath.MatrixProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ColumnGapRule>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.ColumnGapRule{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Row Spacing (Matrix).
  /// </summary>
  private static UInt16? GetRowSpacing(DXMath.MatrixProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.RowSpacing>()?.Val?.Value;
  }
  
  private static bool CmpRowSpacing(DXMath.MatrixProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RowSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.RowSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRowSpacing(DXMath.MatrixProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RowSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.RowSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Matrix Column Spacing.
  /// </summary>
  private static UInt32? GetColumnSpacing(DXMath.MatrixProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.ColumnSpacing>()?.Val?.Value;
  }
  
  private static bool CmpColumnSpacing(DXMath.MatrixProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ColumnSpacing>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.ColumnSpacing", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetColumnSpacing(DXMath.MatrixProperties openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ColumnSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.ColumnSpacing{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Matrix Column Gap.
  /// </summary>
  private static UInt16? GetColumnGap(DXMath.MatrixProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXMath.ColumnGap>()?.Val?.Value;
  }
  
  private static bool CmpColumnGap(DXMath.MatrixProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ColumnGap>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXMath.ColumnGap", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetColumnGap(DXMath.MatrixProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ColumnGap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.ColumnGap{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  private static DMMath.MatrixColumns? GetMatrixColumns(DXMath.MatrixProperties openXmlElement)
  {
    return DMXMath.MatrixColumnsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MatrixColumns>());
  }
  
  private static bool CmpMatrixColumns(DXMath.MatrixProperties openXmlElement, DMMath.MatrixColumns? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MatrixColumns>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrixColumns(DXMath.MatrixProperties openXmlElement, DMMath.MatrixColumns? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixColumns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixColumnsConverter.CreateOpenXmlElement<DXMath.MatrixColumns>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.MatrixProperties openXmlElement)
  {
    return DMXMath.ControlPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.ControlProperties>());
  }
  
  private static bool CmpControlProperties(DXMath.MatrixProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.MatrixProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.MatrixProperties? CreateModelElement(DXMath.MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MatrixProperties();
      value.BaseJustification = GetBaseJustification(openXmlElement);
      value.HidePlaceholder = GetHidePlaceholder(openXmlElement);
      value.RowSpacingRule = GetRowSpacingRule(openXmlElement);
      value.ColumnGapRule = GetColumnGapRule(openXmlElement);
      value.RowSpacing = GetRowSpacing(openXmlElement);
      value.ColumnSpacing = GetColumnSpacing(openXmlElement);
      value.ColumnGap = GetColumnGap(openXmlElement);
      value.MatrixColumns = GetMatrixColumns(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MatrixProperties? openXmlElement, DMMath.MatrixProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBaseJustification(openXmlElement, value.BaseJustification, diffs, objName))
        ok = false;
      if (!CmpHidePlaceholder(openXmlElement, value.HidePlaceholder, diffs, objName))
        ok = false;
      if (!CmpRowSpacingRule(openXmlElement, value.RowSpacingRule, diffs, objName))
        ok = false;
      if (!CmpColumnGapRule(openXmlElement, value.ColumnGapRule, diffs, objName))
        ok = false;
      if (!CmpRowSpacing(openXmlElement, value.RowSpacing, diffs, objName))
        ok = false;
      if (!CmpColumnSpacing(openXmlElement, value.ColumnSpacing, diffs, objName))
        ok = false;
      if (!CmpColumnGap(openXmlElement, value.ColumnGap, diffs, objName))
        ok = false;
      if (!CmpMatrixColumns(openXmlElement, value.MatrixColumns, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixProperties? value)
    where OpenXmlElementType: DXMath.MatrixProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBaseJustification(openXmlElement, value?.BaseJustification);
      SetHidePlaceholder(openXmlElement, value?.HidePlaceholder);
      SetRowSpacingRule(openXmlElement, value?.RowSpacingRule);
      SetColumnGapRule(openXmlElement, value?.ColumnGapRule);
      SetRowSpacing(openXmlElement, value?.RowSpacing);
      SetColumnSpacing(openXmlElement, value?.ColumnSpacing);
      SetColumnGap(openXmlElement, value?.ColumnGap);
      SetMatrixColumns(openXmlElement, value?.MatrixColumns);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
