using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using EquationArrayProperties = DocumentFormat.OpenXml.Math.EquationArrayProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Equation Array Properties.
/// </summary>
public static class EquationArrayPropertiesConverter
{
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public static VerticalAlignmentKind? GetBaseJustification(EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BaseJustification>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<VerticalAlignmentValues, VerticalAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBaseJustification(EquationArrayProperties? openXmlElement, VerticalAlignmentKind? value)
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
  ///   Maximum Distribution.
  /// </summary>
  public static BooleanKind? GetMaxDistribution(EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MaxDistribution>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMaxDistribution(EquationArrayProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MaxDistribution>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MaxDistribution, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public static BooleanKind? GetObjectDistribution(EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ObjectDistribution>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetObjectDistribution(EquationArrayProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ObjectDistribution>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ObjectDistribution, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public static Int64? GetRowSpacingRule(EquationArrayProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RowSpacingRule>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRowSpacingRule(EquationArrayProperties? openXmlElement, Int64? value)
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
  ///   Row Spacing (Equation Array).
  /// </summary>
  public static UInt16? GetRowSpacing(EquationArrayProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RowSpacing>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRowSpacing(EquationArrayProperties? openXmlElement, UInt16? value)
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
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(EquationArrayProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(EquationArrayProperties? openXmlElement, ControlProperties? value)
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

  public static DocumentModel.Math.EquationArrayProperties? CreateModelElement(EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.EquationArrayProperties();
      value.BaseJustification = GetBaseJustification(openXmlElement);
      value.MaxDistribution = GetMaxDistribution(openXmlElement);
      value.ObjectDistribution = GetObjectDistribution(openXmlElement);
      value.RowSpacingRule = GetRowSpacingRule(openXmlElement);
      value.RowSpacing = GetRowSpacing(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.EquationArrayProperties? value)
    where OpenXmlElementType : EquationArrayProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBaseJustification(openXmlElement, value?.BaseJustification);
      SetMaxDistribution(openXmlElement, value?.MaxDistribution);
      SetObjectDistribution(openXmlElement, value?.ObjectDistribution);
      SetRowSpacingRule(openXmlElement, value?.RowSpacingRule);
      SetRowSpacing(openXmlElement, value?.RowSpacing);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}