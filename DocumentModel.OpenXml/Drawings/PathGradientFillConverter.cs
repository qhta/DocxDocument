using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using PathGradientFill = DocumentFormat.OpenXml.Drawing.PathGradientFill;
using RelativeRectangleType = DocumentModel.Drawings.RelativeRectangleType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Path Gradient.
/// </summary>
public static class PathGradientFillConverter
{
  /// <summary>
  ///   Gradient Fill Path
  /// </summary>
  public static PathShadeKind? GetPath(PathGradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<PathShadeValues, PathShadeKind>(openXmlElement?.Path?.Value);
  }

  public static void SetPath(PathGradientFill? openXmlElement, PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<PathShadeValues, PathShadeKind>(value);
  }

  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  public static RelativeRectangleType? GetFillToRectangle(PathGradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FillToRectangle>();
    if (itemElement != null)
      return RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillToRectangle(PathGradientFill? openXmlElement, RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelativeRectangleTypeConverter.CreateOpenXmlElement<FillToRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PathGradientFill? CreateModelElement(PathGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PathGradientFill();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PathGradientFill? value)
    where OpenXmlElementType : PathGradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPath(openXmlElement, value?.Path);
      SetFillToRectangle(openXmlElement, value?.FillToRectangle);
      return openXmlElement;
    }
    return default;
  }
}