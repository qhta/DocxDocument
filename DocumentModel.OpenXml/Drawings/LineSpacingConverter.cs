namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public static class LineSpacingConverter
{
  private static Int32? GetSpacingPercent(DXDraw.LineSpacing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPercent(DXDraw.LineSpacing openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpacingPercent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.SpacingPercent{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSpacingPoints(DXDraw.LineSpacing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPoints(DXDraw.LineSpacing openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpacingPoints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.SpacingPoints{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LineSpacing? CreateModelElement(DXDraw.LineSpacing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineSpacing();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineSpacing? value)
    where OpenXmlElementType: DXDraw.LineSpacing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpacingPercent(openXmlElement, value?.SpacingPercent);
      SetSpacingPoints(openXmlElement, value?.SpacingPoints);
      return openXmlElement;
    }
    return default;
  }
}
