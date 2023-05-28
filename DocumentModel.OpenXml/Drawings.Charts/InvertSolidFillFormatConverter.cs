namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public static class InvertSolidFillFormatConverter
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDC.ShapeProperties2? GetShapeProperties(DXO10DC.InvertSolidFillFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10DC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapeProperties2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO10DC.InvertSolidFillFormat openXmlElement, DMDC.ShapeProperties2? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapeProperties2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10DC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO10DC.InvertSolidFillFormat openXmlElement, DMDC.ShapeProperties2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10DC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapeProperties2Converter.CreateOpenXmlElement<DXO10DC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.InvertSolidFillFormat? CreateModelElement(DXO10DC.InvertSolidFillFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.InvertSolidFillFormat();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10DC.InvertSolidFillFormat? openXmlElement, DMDC.InvertSolidFillFormat? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.InvertSolidFillFormat value)
    where OpenXmlElementType: DXO10DC.InvertSolidFillFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DC.InvertSolidFillFormat openXmlElement, DMDC.InvertSolidFillFormat value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
  }
}
