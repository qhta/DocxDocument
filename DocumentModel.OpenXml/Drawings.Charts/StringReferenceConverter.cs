namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDrawCharts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DXDrawCharts.StringReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  private static DMDrawsCharts.StringCache? GetStringCache(DXDrawCharts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringCache>();
    if (itemElement != null)
      return DMXDrawsCharts.StringCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringCache(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StringCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringCacheConverter.CreateOpenXmlElement<DXDrawCharts.StringCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  private static DMDrawsCharts.StrRefExtensionList? GetStrRefExtensionList(DXDrawCharts.StringReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StrRefExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.StrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStrRefExtensionList(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StrRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StrRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StrRefExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StrRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StringReference? CreateModelElement(DXDrawCharts.StringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringReference();
      value.Formula = GetFormula(openXmlElement);
      value.StringCache = GetStringCache(openXmlElement);
      value.StrRefExtensionList = GetStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringReference? value)
    where OpenXmlElementType: DXDrawCharts.StringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetStringCache(openXmlElement, value?.StringCache);
      SetStrRefExtensionList(openXmlElement, value?.StrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
