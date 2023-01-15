using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Diagram = DocumentFormat.OpenXml.Vml.Office.Diagram;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   VML Diagram.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(Diagram? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(Diagram? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  public static Int64? GetStyle(Diagram? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Style = value;
  }

  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  public static Boolean? GetAutoFormat(Diagram? openXmlElement)
  {
    return openXmlElement?.AutoFormat?.Value;
  }

  public static void SetAutoFormat(Diagram? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoFormat = value;
      else
        openXmlElement.AutoFormat = null;
  }

  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  public static Boolean? GetReverse(Diagram? openXmlElement)
  {
    return openXmlElement?.Reverse?.Value;
  }

  public static void SetReverse(Diagram? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Reverse = value;
      else
        openXmlElement.Reverse = null;
  }

  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  public static Boolean? GetAutoLayout(Diagram? openXmlElement)
  {
    return openXmlElement?.AutoLayout?.Value;
  }

  public static void SetAutoLayout(Diagram? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AutoLayout = value;
      else
        openXmlElement.AutoLayout = null;
  }

  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  public static Int64? GetScaleX(Diagram? openXmlElement)
  {
    return openXmlElement?.ScaleX?.Value;
  }

  public static void SetScaleX(Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ScaleX = value;
  }

  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  public static Int64? GetScaleY(Diagram? openXmlElement)
  {
    return openXmlElement?.ScaleY?.Value;
  }

  public static void SetScaleY(Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ScaleY = value;
  }

  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  public static Int64? GetFontSize(Diagram? openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }

  public static void SetFontSize(Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontSize = value;
  }

  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  public static String? GetConstrainBounds(Diagram? openXmlElement)
  {
    return openXmlElement?.ConstrainBounds?.Value;
  }

  public static void SetConstrainBounds(Diagram? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConstrainBounds = new StringValue { Value = value };
      else
        openXmlElement.ConstrainBounds = null;
  }

  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  public static Int64? GetBaseTextScale(Diagram? openXmlElement)
  {
    return openXmlElement?.BaseTextScale?.Value;
  }

  public static void SetBaseTextScale(Diagram? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BaseTextScale = value;
  }

  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  public static RelationTable? GetRelationTable(Diagram? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
    if (itemElement != null)
      return RelationTableConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRelationTable(Diagram? openXmlElement, RelationTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.RelationTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.Diagram? CreateModelElement(Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Diagram();
      value.Extension = GetExtension(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.AutoFormat = GetAutoFormat(openXmlElement);
      value.Reverse = GetReverse(openXmlElement);
      value.AutoLayout = GetAutoLayout(openXmlElement);
      value.ScaleX = GetScaleX(openXmlElement);
      value.ScaleY = GetScaleY(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      value.ConstrainBounds = GetConstrainBounds(openXmlElement);
      value.BaseTextScale = GetBaseTextScale(openXmlElement);
      value.RelationTable = GetRelationTable(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Diagram? value)
    where OpenXmlElementType : Diagram, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetStyle(openXmlElement, value?.Style);
      SetAutoFormat(openXmlElement, value?.AutoFormat);
      SetReverse(openXmlElement, value?.Reverse);
      SetAutoLayout(openXmlElement, value?.AutoLayout);
      SetScaleX(openXmlElement, value?.ScaleX);
      SetScaleY(openXmlElement, value?.ScaleY);
      SetFontSize(openXmlElement, value?.FontSize);
      SetConstrainBounds(openXmlElement, value?.ConstrainBounds);
      SetBaseTextScale(openXmlElement, value?.BaseTextScale);
      SetRelationTable(openXmlElement, value?.RelationTable);
      return openXmlElement;
    }
    return default;
  }
}