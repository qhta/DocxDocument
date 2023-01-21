namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  private static String? GetId(DXDrawCharts.ExternalData openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXDrawCharts.ExternalData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  private static Boolean? GetAutoUpdate(DXDrawCharts.ExternalData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AutoUpdate>();
    return itemElement != null;
  }
  
  private static void SetAutoUpdate(DXDrawCharts.ExternalData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AutoUpdate>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.AutoUpdate();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ExternalData? CreateModelElement(DXDrawCharts.ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ExternalData? value)
    where OpenXmlElementType: DXDrawCharts.ExternalData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAutoUpdate(openXmlElement, value?.AutoUpdate);
      return openXmlElement;
    }
    return default;
  }
}
