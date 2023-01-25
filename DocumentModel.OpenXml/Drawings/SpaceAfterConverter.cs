namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space After.
/// </summary>
public static class SpaceAfterConverter
{
  private static Int32? GetSpacingPercent(DXDraw.SpaceAfter openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val?.Value;
  }
  
  private static bool CmpSpacingPercent(DXDraw.SpaceAfter openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SpacingPercent", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val?.Value;
  }
  
  private static bool CmpSpacingPoints(DXDraw.SpaceAfter openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SpacingPoints", itemElement?.Val?.Value, value);
    return false;
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
  
  public static bool CompareModelElement(DXDraw.SpaceAfter? openXmlElement, DMDraws.SpaceAfter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSpacingPercent(openXmlElement, value.SpacingPercent, diffs, objName))
        ok = false;
      if (!CmpSpacingPoints(openXmlElement, value.SpacingPoints, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
