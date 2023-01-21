namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public static class StrRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.StrRefExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.StrRefExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FullReference? GetFullReference(DXDrawCharts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FullReference>();
    if (itemElement != null)
      return DMXDrawsCharts.FullReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFullReference(DXDrawCharts.StrRefExtension openXmlElement, DMDrawsCharts.FullReference? value)
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
  
  private static DMDrawsCharts.LevelReference? GetLevelReference(DXDrawCharts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.LevelReference>();
    if (itemElement != null)
      return DMXDrawsCharts.LevelReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevelReference(DXDrawCharts.StrRefExtension openXmlElement, DMDrawsCharts.LevelReference? value)
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
  
  private static DMDrawsCharts.FormulaReference? GetFormulaReference(DXDrawCharts.StrRefExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FormulaReference>();
    if (itemElement != null)
      return DMXDrawsCharts.FormulaReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormulaReference(DXDrawCharts.StrRefExtension openXmlElement, DMDrawsCharts.FormulaReference? value)
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
  
  public static DMDrawsCharts.StrRefExtension? CreateModelElement(DXDrawCharts.StrRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StrRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrRefExtension? value)
    where OpenXmlElementType: DXDrawCharts.StrRefExtension, new()
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
