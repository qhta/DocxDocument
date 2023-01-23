namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public static class MultiLvlStrRefExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.MultiLvlStrRefExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FullReference? GetFullReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement)
  {
    return DMXDrawsCharts.FullReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FullReference>());
  }
  
  private static bool CmpFullReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.FullReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FullReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FullReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFullReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.FullReference? value)
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
  
  private static DMDrawsCharts.LevelReference? GetLevelReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement)
  {
    return DMXDrawsCharts.LevelReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.LevelReference>());
  }
  
  private static bool CmpLevelReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.LevelReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LevelReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.LevelReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLevelReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.LevelReference? value)
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
  
  private static DMDrawsCharts.FormulaReference? GetFormulaReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement)
  {
    return DMXDrawsCharts.FormulaReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FormulaReference>());
  }
  
  private static bool CmpFormulaReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.FormulaReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FormulaReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FormulaReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormulaReference(DXDrawCharts.MultiLvlStrRefExtension openXmlElement, DMDrawsCharts.FormulaReference? value)
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
  
  public static DMDrawsCharts.MultiLvlStrRefExtension? CreateModelElement(DXDrawCharts.MultiLvlStrRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.MultiLvlStrRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.MultiLvlStrRefExtension? openXmlElement, DMDrawsCharts.MultiLvlStrRefExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFullReference(openXmlElement, value.FullReference, diffs, objName))
        ok = false;
      if (!CmpLevelReference(openXmlElement, value.LevelReference, diffs, objName))
        ok = false;
      if (!CmpFormulaReference(openXmlElement, value.FormulaReference, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.MultiLvlStrRefExtension? value)
    where OpenXmlElementType: DXDrawCharts.MultiLvlStrRefExtension, new()
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
