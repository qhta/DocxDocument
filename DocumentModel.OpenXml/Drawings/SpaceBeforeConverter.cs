namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space Before.
/// </summary>
public static class SpaceBeforeConverter
{
  private static Int32? GetSpacingPercent(DXDraw.SpaceBefore openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val?.Value;
  }
  
  private static bool CmpSpacingPercent(DXDraw.SpaceBefore openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>()?.Val?.Value == value;
  }
  
  private static void SetSpacingPercent(DXDraw.SpaceBefore openXmlElement, Int32? value)
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
  
  private static Int32? GetSpacingPoints(DXDraw.SpaceBefore openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val?.Value;
  }
  
  private static bool CmpSpacingPoints(DXDraw.SpaceBefore openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>()?.Val?.Value == value;
  }
  
  private static void SetSpacingPoints(DXDraw.SpaceBefore openXmlElement, Int32? value)
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
  
  public static DMDraws.SpaceBefore? CreateModelElement(DXDraw.SpaceBefore? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SpaceBefore();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.SpaceBefore? openXmlElement, DMDraws.SpaceBefore? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SpaceBefore? value)
    where OpenXmlElementType: DXDraw.SpaceBefore, new()
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
