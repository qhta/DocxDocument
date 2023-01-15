using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Defines the MarkerType Class.
/// </summary>
public static class MarkerTypeConverter
{
  /// <summary>
  ///   Relative X Coordinate.
  /// </summary>
  public static String? GetXPosition(MarkerType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetXPosition(MarkerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<XPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new XPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Relative Y Coordinate.
  /// </summary>
  public static String? GetYPosition(MarkerType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetYPosition(MarkerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<YPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new YPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.MarkerType? CreateModelElement(MarkerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.MarkerType();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.MarkerType? value)
    where OpenXmlElementType : MarkerType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetXPosition(openXmlElement, value?.XPosition);
      SetYPosition(openXmlElement, value?.YPosition);
      return openXmlElement;
    }
    return default;
  }
}