namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space After.
/// </summary>
public static class SpaceAfterConverter
{
  private static Int32? GetSpacingPercent(DXDraw.SpaceAfter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPercent(DXDraw.SpaceAfter openXmlElement, Int32? value)
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
  
  private static Int32? GetSpacingPoints(DXDraw.SpaceAfter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPoints(DXDraw.SpaceAfter openXmlElement, Int32? value)
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
  
  public static DMDraws.SpaceAfter? CreateModelElement(DXDraw.SpaceAfter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SpaceAfter();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SpaceAfter? value)
    where OpenXmlElementType: DXDraw.SpaceAfter, new()
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
