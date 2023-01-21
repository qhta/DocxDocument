namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public static class ConnectionSiteConverter
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  private static String? GetAngle(DXDraw.ConnectionSite openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  private static void SetAngle(DXDraw.ConnectionSite openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Angle = new StringValue { Value = value };
    else
      openXmlElement.Angle = null;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPosition(DXDraw.ConnectionSite openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Position>();
    if (itemElement != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPosition(DXDraw.ConnectionSite openXmlElement, DMDraws.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXDraw.Position>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ConnectionSite? CreateModelElement(DXDraw.ConnectionSite? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectionSite();
      value.Angle = GetAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionSite? value)
    where OpenXmlElementType: DXDraw.ConnectionSite, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
