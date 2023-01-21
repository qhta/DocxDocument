namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public static class NumberReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDrawCharts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormula(DXDrawCharts.NumberReference openXmlElement, String? value)
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
  /// NumberingCache.
  /// </summary>
  private static DMDrawsCharts.NumberingCache? GetNumberingCache(DXDrawCharts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingCache>();
    if (itemElement != null)
      return DMXDrawsCharts.NumberingCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingCache(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumberingCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberingCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberingCacheConverter.CreateOpenXmlElement<DXDrawCharts.NumberingCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  private static DMDrawsCharts.NumRefExtensionList? GetNumRefExtensionList(DXDrawCharts.NumberReference openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumRefExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.NumRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumRefExtensionList(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumRefExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.NumRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.NumberReference? CreateModelElement(DXDrawCharts.NumberReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumberReference();
      value.Formula = GetFormula(openXmlElement);
      value.NumberingCache = GetNumberingCache(openXmlElement);
      value.NumRefExtensionList = GetNumRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberReference? value)
    where OpenXmlElementType: DXDrawCharts.NumberReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetNumberingCache(openXmlElement, value?.NumberingCache);
      SetNumRefExtensionList(openXmlElement, value?.NumRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
