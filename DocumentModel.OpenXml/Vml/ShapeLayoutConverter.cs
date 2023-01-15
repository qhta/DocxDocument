using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using ShapeLayout = DocumentFormat.OpenXml.Vml.Office.ShapeLayout;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Layout Properties.
/// </summary>
public static class ShapeLayoutConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(ShapeLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(ShapeLayout? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  public static ShapeIdMap? GetShapeIdMap(ShapeLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
    if (itemElement != null)
      return ShapeIdMapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeIdMap(ShapeLayout? openXmlElement, ShapeIdMap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeIdMapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  public static RegroupTable? GetRegroupTable(ShapeLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
    if (itemElement != null)
      return RegroupTableConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRegroupTable(ShapeLayout? openXmlElement, RegroupTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RegroupTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.RegroupTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Rule Set.
  /// </summary>
  public static Rules? GetRules(ShapeLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
    if (itemElement != null)
      return RulesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRules(ShapeLayout? openXmlElement, Rules? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RulesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Rules>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.ShapeLayout? CreateModelElement(ShapeLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeLayout();
      value.Extension = GetExtension(openXmlElement);
      value.ShapeIdMap = GetShapeIdMap(openXmlElement);
      value.RegroupTable = GetRegroupTable(openXmlElement);
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeLayout? value)
    where OpenXmlElementType : ShapeLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetShapeIdMap(openXmlElement, value?.ShapeIdMap);
      SetRegroupTable(openXmlElement, value?.RegroupTable);
      SetRules(openXmlElement, value?.Rules);
      return openXmlElement;
    }
    return default;
  }
}