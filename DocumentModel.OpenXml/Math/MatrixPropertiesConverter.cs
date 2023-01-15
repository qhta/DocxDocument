using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using MatrixColumns = DocumentModel.Math.MatrixColumns;
using MatrixProperties = DocumentFormat.OpenXml.Math.MatrixProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Matrix Properties.
/// </summary>
public static class MatrixPropertiesConverter
{
  /// <summary>
  ///   Matrix Base Justification.
  /// </summary>
  public static VerticalAlignmentKind? GetBaseJustification(MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BaseJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalAlignmentValues, VerticalAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBaseJustification(MatrixProperties? openXmlElement, VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BaseJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BaseJustification, VerticalAlignmentValues, VerticalAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Placeholders (Matrix).
  /// </summary>
  public static BooleanKind? GetHidePlaceholder(MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HidePlaceholder>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHidePlaceholder(MatrixProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HidePlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HidePlaceholder, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public static Int64? GetRowSpacingRule(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RowSpacingRule>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRowSpacingRule(MatrixProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RowSpacingRule>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RowSpacingRule { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Matrix Column Gap Rule.
  /// </summary>
  public static Int64? GetColumnGapRule(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnGapRule>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnGapRule(MatrixProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnGapRule>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnGapRule { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Row Spacing (Matrix).
  /// </summary>
  public static UInt16? GetRowSpacing(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RowSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRowSpacing(MatrixProperties? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RowSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RowSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Matrix Column Spacing.
  /// </summary>
  public static UInt32? GetColumnSpacing(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnSpacing(MatrixProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnSpacing { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  public static UInt16? GetColumnGap(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnGap>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnGap(MatrixProperties? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnGap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnGap { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  public static MatrixColumns? GetMatrixColumns(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
    if (itemElement != null)
      return MatrixColumnsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMatrixColumns(MatrixProperties? openXmlElement, MatrixColumns? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixColumnsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MatrixColumns>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(MatrixProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(MatrixProperties? openXmlElement, ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.MatrixProperties? CreateModelElement(MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixProperties();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MatrixProperties? value)
    where OpenXmlElementType : MatrixProperties, new()
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