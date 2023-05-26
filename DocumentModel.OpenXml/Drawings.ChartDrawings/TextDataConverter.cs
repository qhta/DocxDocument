namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public static class TextDataConverter
{
  private static DMDCDs.OpenXmlFormulaElement? GetFormula(DXO16DCD.TextData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Formula>();
    if (element != null)
      return DMXDCDs.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormula(DXO16DCD.TextData openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Formula>(), value, diffs, objName, propName);
  }
  
  private static void SetFormula(DXO16DCD.TextData openXmlElement, DMDCDs.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DXO16DCD.Formula>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetVXsdstring(DXO16DCD.TextData openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.VXsdstring>()?.Text;
  }
  
  private static bool CmpVXsdstring(DXO16DCD.TextData openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.VXsdstring>()?.Text == value;
  }
  
  private static void SetVXsdstring(DXO16DCD.TextData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.VXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.VXsdstring { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.TextData? CreateModelElement(DXO16DCD.TextData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.TextData();
      value.Formula = GetFormula(openXmlElement);
      value.VXsdstring = GetVXsdstring(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.TextData? openXmlElement, DMDCDs.TextData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName, propName))
        ok = false;
      if (!CmpVXsdstring(openXmlElement, value.VXsdstring, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.TextData value)
    where OpenXmlElementType: DXO16DCD.TextData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.TextData openXmlElement, DMDCDs.TextData value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetVXsdstring(openXmlElement, value?.VXsdstring);
  }
}
