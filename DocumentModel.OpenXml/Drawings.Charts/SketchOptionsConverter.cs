namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public static class SketchOptionsConverter
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  private static Boolean? GetInSketchMode(DXO2010DrawCharts.SketchOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.InSketchMode>();
    return itemElement != null;
  }
  
  private static void SetInSketchMode(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.InSketchMode>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.InSketchMode();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  private static Boolean? GetShowSketchButton(DXO2010DrawCharts.SketchOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShowSketchButton>();
    return itemElement != null;
  }
  
  private static void SetShowSketchButton(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShowSketchButton>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.ShowSketchButton();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SketchOptions? CreateModelElement(DXO2010DrawCharts.SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SketchOptions();
      value.InSketchMode = GetInSketchMode(openXmlElement);
      value.ShowSketchButton = GetShowSketchButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SketchOptions? value)
    where OpenXmlElementType: DXO2010DrawCharts.SketchOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInSketchMode(openXmlElement, value?.InSketchMode);
      SetShowSketchButton(openXmlElement, value?.ShowSketchButton);
      return openXmlElement;
    }
    return default;
  }
}
