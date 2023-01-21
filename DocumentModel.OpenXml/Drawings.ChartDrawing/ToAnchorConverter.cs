namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public static class ToAnchorConverter
{
  private static String? GetXPosition(DXDrawChartDraw.ToAnchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetXPosition(DXDrawChartDraw.ToAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.XPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawChartDraw.XPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetYPosition(DXDrawChartDraw.ToAnchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetYPosition(DXDrawChartDraw.ToAnchor openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.YPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawChartDraw.YPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.ToAnchor? CreateModelElement(DXDrawChartDraw.ToAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.ToAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.ToAnchor? value)
    where OpenXmlElementType: DXDrawChartDraw.ToAnchor, new()
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
