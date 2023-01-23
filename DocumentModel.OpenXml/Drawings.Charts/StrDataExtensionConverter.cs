namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public static class StrDataExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.StrDataExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.StrDataExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.StrDataExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static Boolean? GetAutoGeneneratedCategories(DXDrawCharts.StrDataExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.AutoGeneneratedCategories>() != null;
  }
  
  private static bool CmpAutoGeneneratedCategories(DXDrawCharts.StrDataExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.AutoGeneneratedCategories>() != null == value;
  }
  
  private static void SetAutoGeneneratedCategories(DXDrawCharts.StrDataExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.AutoGeneneratedCategories>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.AutoGeneneratedCategories();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StrDataExtension? CreateModelElement(DXDrawCharts.StrDataExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StrDataExtension();
      value.Uri = GetUri(openXmlElement);
      value.AutoGeneneratedCategories = GetAutoGeneneratedCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StrDataExtension? openXmlElement, DMDrawsCharts.StrDataExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpAutoGeneneratedCategories(openXmlElement, value.AutoGeneneratedCategories, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrDataExtension? value)
    where OpenXmlElementType: DXDrawCharts.StrDataExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetAutoGeneneratedCategories(openXmlElement, value?.AutoGeneneratedCategories);
      return openXmlElement;
    }
    return default;
  }
}
