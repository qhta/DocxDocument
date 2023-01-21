namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Custom Dash.
/// </summary>
public static class CustomDashConverter
{
  private static Collection<DMDraws.DashStop> GetDashStops(DXDraw.CustomDash openXmlElement)
  {
    var collection = new Collection<DMDraws.DashStop>();
    foreach (var item in openXmlElement.Elements<DXDraw.DashStop>())
    {
      var newItem = DMXDraws.DashStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDashStops(DXDraw.CustomDash openXmlElement, Collection<DMDraws.DashStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.DashStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.DashStopConverter.CreateOpenXmlElement<DXDraw.DashStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.CustomDash? CreateModelElement(DXDraw.CustomDash? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CustomDash();
      value.DashStops = GetDashStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CustomDash? value)
    where OpenXmlElementType: DXDraw.CustomDash, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDashStops(openXmlElement, value?.DashStops);
      return openXmlElement;
    }
    return default;
  }
}
