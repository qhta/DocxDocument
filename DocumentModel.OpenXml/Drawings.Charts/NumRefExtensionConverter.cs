namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public static class NumRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.NumRefExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.NumRefExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FullReference? GetFullReference(DXDrawCharts.NumRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FullReference>();
    if (itemElement != null)
      return DMXDrawsCharts.FullReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFullReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.FullReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FullReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FullReferenceConverter.CreateOpenXmlElement<DXO2013DrawChart.FullReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.LevelReference? GetLevelReference(DXDrawCharts.NumRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.LevelReference>();
    if (itemElement != null)
      return DMXDrawsCharts.LevelReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevelReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.LevelReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.LevelReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LevelReferenceConverter.CreateOpenXmlElement<DXO2013DrawChart.LevelReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.FormulaReference? GetFormulaReference(DXDrawCharts.NumRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FormulaReference>();
    if (itemElement != null)
      return DMXDrawsCharts.FormulaReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormulaReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.FormulaReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FormulaReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FormulaReferenceConverter.CreateOpenXmlElement<DXO2013DrawChart.FormulaReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.NumRefExtension? CreateModelElement(DXDrawCharts.NumRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumRefExtension? value)
    where OpenXmlElementType: DXDrawCharts.NumRefExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFullReference(openXmlElement, value?.FullReference);
      SetLevelReference(openXmlElement, value?.LevelReference);
      SetFormulaReference(openXmlElement, value?.FormulaReference);
      return openXmlElement;
    }
    return default;
  }
}
