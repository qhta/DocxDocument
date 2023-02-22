namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
public static class ToAnchorConverter
{
  private static String? GetXPosition(DXDrawChartDraw.ToAnchor openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>()?.Text;
  }
  
  private static bool CmpXPosition(DXDrawChartDraw.ToAnchor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>()?.Text == value;
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
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>()?.Text;
  }
  
  private static bool CmpYPosition(DXDrawChartDraw.ToAnchor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>()?.Text == value;
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
  
  public static DocumentModel.Drawings.ChartDrawing.ToAnchor? CreateModelElement(DXDrawChartDraw.ToAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.ToAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.ToAnchor? openXmlElement, DMDrawsChartDraw.ToAnchor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXPosition(openXmlElement, value.XPosition, diffs, objName))
        ok = false;
      if (!CmpYPosition(openXmlElement, value.YPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.ToAnchor value)
    where OpenXmlElementType: DXDrawChartDraw.ToAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.ToAnchor openXmlElement, DMDrawsChartDraw.ToAnchor value)
  {
    SetXPosition(openXmlElement, value?.XPosition);
    SetYPosition(openXmlElement, value?.YPosition);
    }
  }
