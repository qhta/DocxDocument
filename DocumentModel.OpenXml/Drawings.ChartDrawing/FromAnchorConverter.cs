namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public static class FromAnchorConverter
{
  private static String? GetXPosition(DXDrawChartDraw.FromAnchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetXPosition(DXDrawChartDraw.FromAnchor openXmlElement, String? value)
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
  
  private static String? GetYPosition(DXDrawChartDraw.FromAnchor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetYPosition(DXDrawChartDraw.FromAnchor openXmlElement, String? value)
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
  
  public static DMDrawsChartDraw.FromAnchor? CreateModelElement(DXDrawChartDraw.FromAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.FromAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.FromAnchor? value)
    where OpenXmlElementType: DXDrawChartDraw.FromAnchor, new()
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
