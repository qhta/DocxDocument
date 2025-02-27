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
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.NumRefExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.NumRefExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FullReference? GetFullReference(DXDrawCharts.NumRefExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FullReference>();
    if (element != null)
      return DMXDrawsCharts.FullReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFullReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.FullReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FullReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FullReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.LevelReference>();
    if (element != null)
      return DMXDrawsCharts.LevelReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevelReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.LevelReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LevelReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.LevelReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FormulaReference>();
    if (element != null)
      return DMXDrawsCharts.FormulaReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormulaReference(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.FormulaReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FormulaReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FormulaReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Charts.NumRefExtension? CreateModelElement(DXDrawCharts.NumRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumRefExtension? openXmlElement, DMDrawsCharts.NumRefExtension? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumRefExtension value)
    where OpenXmlElementType: DXDrawCharts.NumRefExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.NumRefExtension openXmlElement, DMDrawsCharts.NumRefExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFullReference(openXmlElement, value?.FullReference);
    SetLevelReference(openXmlElement, value?.LevelReference);
    SetFormulaReference(openXmlElement, value?.FormulaReference);
  }
}
