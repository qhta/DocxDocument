using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Point = DocumentFormat.OpenXml.Drawing.Diagrams.Point;
using PropertySet = DocumentModel.Drawings.Diagrams.PropertySet;
using PtExtensionList = DocumentModel.Drawings.Diagrams.PtExtensionList;
using ShapeProperties = DocumentModel.Drawings.Diagrams.ShapeProperties;
using TextBody = DocumentModel.Drawings.Diagrams.TextBody;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Point.
/// </summary>
public static class PointConverter
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public static String? GetModelId(Point? openXmlElement)
  {
    return openXmlElement?.ModelId?.Value;
  }

  public static void SetModelId(Point? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ModelId = new StringValue { Value = value };
      else
        openXmlElement.ModelId = null;
  }

  /// <summary>
  ///   Point Type
  /// </summary>
  public static PointKind? GetType(Point? openXmlElement)
  {
    return EnumValueConverter.GetValue<PointValues, PointKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Point? openXmlElement, PointKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<PointValues, PointKind>(value);
  }

  /// <summary>
  ///   Connection Identifier
  /// </summary>
  public static String? GetConnectionId(Point? openXmlElement)
  {
    return openXmlElement?.ConnectionId?.Value;
  }

  public static void SetConnectionId(Point? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConnectionId = new StringValue { Value = value };
      else
        openXmlElement.ConnectionId = null;
  }

  /// <summary>
  ///   Property Set.
  /// </summary>
  public static PropertySet? GetPropertySet(Point? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
    if (itemElement != null)
      return PropertySetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPropertySet(Point? openXmlElement, PropertySet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PropertySetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Point? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Point? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Body.
  /// </summary>
  public static TextBody? GetTextBody(Point? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
    if (itemElement != null)
      return TextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBody(Point? openXmlElement, TextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  public static PtExtensionList? GetPtExtensionList(Point? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
    if (itemElement != null)
      return PtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPtExtensionList(Point? openXmlElement, PtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Point? CreateModelElement(Point? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Point();
      value.ModelId = GetModelId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.ConnectionId = GetConnectionId(openXmlElement);
      value.PropertySet = GetPropertySet(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      value.PtExtensionList = GetPtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Point? value)
    where OpenXmlElementType : Point, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetModelId(openXmlElement, value?.ModelId);
      SetType(openXmlElement, value?.Type);
      SetConnectionId(openXmlElement, value?.ConnectionId);
      SetPropertySet(openXmlElement, value?.PropertySet);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextBody(openXmlElement, value?.TextBody);
      SetPtExtensionList(openXmlElement, value?.PtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}