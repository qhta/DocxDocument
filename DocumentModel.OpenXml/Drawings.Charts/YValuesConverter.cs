namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public static class YValuesConverter
{
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.YValues openXmlElement)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>());
  }
  
  private static bool CmpNumberReference(DXDrawCharts.YValues openXmlElement, DMDrawsCharts.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberReference(DXDrawCharts.YValues openXmlElement, DMDrawsCharts.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberReferenceConverter.CreateOpenXmlElement<DXDrawCharts.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.YValues openXmlElement)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>());
  }
  
  private static bool CmpNumberLiteral(DXDrawCharts.YValues openXmlElement, DMDrawsCharts.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberLiteral(DXDrawCharts.YValues openXmlElement, DMDrawsCharts.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberLiteralConverter.CreateOpenXmlElement<DXDrawCharts.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.YValues? CreateModelElement(DXDrawCharts.YValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.YValues();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.YValues? openXmlElement, DMDrawsCharts.YValues? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.YValues? value)
    where OpenXmlElementType: DXDrawCharts.YValues, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      return openXmlElement;
    }
    return default;
  }
}
