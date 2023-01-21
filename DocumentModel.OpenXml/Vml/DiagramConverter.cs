namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public static class DiagramConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Diagram openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.Diagram openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  private static Int64? GetStyle(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement.Style?.Value;
  }
  
  private static void SetStyle(DXVmlO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.Style = value;
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  private static Boolean? GetAutoFormat(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement?.AutoFormat?.Value;
  }
  
  private static void SetAutoFormat(DXVmlO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoFormat = value;
    else
      openXmlElement.AutoFormat = null;
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  private static Boolean? GetReverse(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement?.Reverse?.Value;
  }
  
  private static void SetReverse(DXVmlO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Reverse = value;
    else
      openXmlElement.Reverse = null;
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  private static Boolean? GetAutoLayout(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement?.AutoLayout?.Value;
  }
  
  private static void SetAutoLayout(DXVmlO.Diagram openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoLayout = value;
    else
      openXmlElement.AutoLayout = null;
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  private static Int64? GetScaleX(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement.ScaleX?.Value;
  }
  
  private static void SetScaleX(DXVmlO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleX = value;
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  private static Int64? GetScaleY(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement.ScaleY?.Value;
  }
  
  private static void SetScaleY(DXVmlO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.ScaleY = value;
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  private static Int64? GetFontSize(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement.FontSize?.Value;
  }
  
  private static void SetFontSize(DXVmlO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.FontSize = value;
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  private static String? GetConstrainBounds(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement?.ConstrainBounds?.Value;
  }
  
  private static void SetConstrainBounds(DXVmlO.Diagram openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConstrainBounds = new StringValue { Value = value };
    else
      openXmlElement.ConstrainBounds = null;
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  private static Int64? GetBaseTextScale(DXVmlO.Diagram openXmlElement)
  {
    return openXmlElement.BaseTextScale?.Value;
  }
  
  private static void SetBaseTextScale(DXVmlO.Diagram openXmlElement, Int64? value)
  {
    openXmlElement.BaseTextScale = value;
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  private static DMVml.RelationTable? GetRelationTable(DXVmlO.Diagram openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXVmlO.RelationTable>();
    if (itemElement != null)
      return DMXVml.RelationTableConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelationTable(DXVmlO.Diagram openXmlElement, DMVml.RelationTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.RelationTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RelationTableConverter.CreateOpenXmlElement<DXVmlO.RelationTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.Diagram? CreateModelElement(DXVmlO.Diagram? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Diagram();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Diagram? value)
    where OpenXmlElementType: DXVmlO.Diagram, new()
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
