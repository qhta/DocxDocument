using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueColorMiddlePosition Class.
/// </summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  ///   NumberColorPosition.
  /// </summary>
  public static Double? GetNumberColorPosition(ValueColorMiddlePosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetNumberColorPosition(ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NumberColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new NumberColorPosition { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  public static Double? GetPercentageColorPosition(ValueColorMiddlePosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPercentageColorPosition(ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PercentageColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PercentageColorPosition { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? CreateModelElement(ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition();
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? value)
    where OpenXmlElementType : ValueColorMiddlePosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}