namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public static class TextSpacingTypeConverter
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  private static Int32? GetSpacingPercent(DXDraw.TextSpacingType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPercent(DXDraw.TextSpacingType openXmlElement, Int32? value)
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
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  private static Int32? GetSpacingPoints(DXDraw.TextSpacingType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPoints(DXDraw.TextSpacingType openXmlElement, Int32? value)
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
  
  public static DMDraws.TextSpacingType? CreateModelElement(DXDraw.TextSpacingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TextSpacingType();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TextSpacingType? value)
    where OpenXmlElementType: DXDraw.TextSpacingType, new()
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
