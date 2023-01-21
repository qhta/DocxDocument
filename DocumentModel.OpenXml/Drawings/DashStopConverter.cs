namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public static class DashStopConverter
{
  /// <summary>
  /// Dash Length
  /// </summary>
  private static Int32? GetDashLength(DXDraw.DashStop openXmlElement)
  {
    return openXmlElement.DashLength?.Value;
  }
  
  private static void SetDashLength(DXDraw.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.DashLength = value;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  private static Int32? GetSpaceLength(DXDraw.DashStop openXmlElement)
  {
    return openXmlElement.SpaceLength?.Value;
  }
  
  private static void SetSpaceLength(DXDraw.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.SpaceLength = value;
  }
  
  public static DMDraws.DashStop? CreateModelElement(DXDraw.DashStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.DashStop();
      value.DashLength = GetDashLength(openXmlElement);
      value.SpaceLength = GetSpaceLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.DashStop? value)
    where OpenXmlElementType: DXDraw.DashStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDashLength(openXmlElement, value?.DashLength);
      SetSpaceLength(openXmlElement, value?.SpaceLength);
      return openXmlElement;
    }
    return default;
  }
}
