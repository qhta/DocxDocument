using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Starting Anchor Point.
/// </summary>
public static class FromAnchorConverter
{
  public static String? GetXPosition(FromAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetXPosition(FromAnchor? openXmlElement, String? value)
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

  public static String? GetYPosition(FromAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetYPosition(FromAnchor? openXmlElement, String? value)
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

  public static DocumentModel.Drawings.ChartDrawing.FromAnchor? CreateModelElement(FromAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.FromAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.FromAnchor? value)
    where OpenXmlElementType : FromAnchor, new()
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