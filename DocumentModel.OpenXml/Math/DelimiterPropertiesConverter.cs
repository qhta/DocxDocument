using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using DelimiterProperties = DocumentFormat.OpenXml.Math.DelimiterProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Delimiter Properties.
/// </summary>
public static class DelimiterPropertiesConverter
{
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  public static String? GetBeginChar(DelimiterProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BeginChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBeginChar(DelimiterProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BeginChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BeginChar { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  public static String? GetSeparatorChar(DelimiterProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SeparatorChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSeparatorChar(DelimiterProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SeparatorChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SeparatorChar { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  public static String? GetEndChar(DelimiterProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetEndChar(DelimiterProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EndChar { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  public static BooleanKind? GetGrowOperators(DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GrowOperators>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetGrowOperators(DelimiterProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GrowOperators>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<GrowOperators, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  public static ShapeDelimiterKind? GetShape(DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shape>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ShapeDelimiterValues, ShapeDelimiterKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetShape(DelimiterProperties? openXmlElement, ShapeDelimiterKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Shape, ShapeDelimiterValues, ShapeDelimiterKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(DelimiterProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(DelimiterProperties? openXmlElement, ControlProperties? value)
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

  public static DocumentModel.Math.DelimiterProperties? CreateModelElement(DelimiterProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.DelimiterProperties();
      value.BeginChar = GetBeginChar(openXmlElement);
      value.SeparatorChar = GetSeparatorChar(openXmlElement);
      value.EndChar = GetEndChar(openXmlElement);
      value.GrowOperators = GetGrowOperators(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.DelimiterProperties? value)
    where OpenXmlElementType : DelimiterProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBeginChar(openXmlElement, value?.BeginChar);
      SetSeparatorChar(openXmlElement, value?.SeparatorChar);
      SetEndChar(openXmlElement, value?.EndChar);
      SetGrowOperators(openXmlElement, value?.GrowOperators);
      SetShape(openXmlElement, value?.Shape);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}