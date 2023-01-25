namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public static class NumberDataSourceTypeConverter
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.NumberDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>());
  }
  
  private static bool CmpNumberReference(DXDrawCharts.NumberDataSourceType openXmlElement, DMDrawsCharts.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberReference(DXDrawCharts.NumberDataSourceType openXmlElement, DMDrawsCharts.NumberReference? value)
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
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.NumberDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>());
  }
  
  private static bool CmpNumberLiteral(DXDrawCharts.NumberDataSourceType openXmlElement, DMDrawsCharts.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberLiteral(DXDrawCharts.NumberDataSourceType openXmlElement, DMDrawsCharts.NumberLiteral? value)
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
  
  public static DMDrawsCharts.NumberDataSourceType? CreateModelElement(DXDrawCharts.NumberDataSourceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumberDataSourceType();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumberDataSourceType? openXmlElement, DMDrawsCharts.NumberDataSourceType? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberDataSourceType? value)
    where OpenXmlElementType: DXDrawCharts.NumberDataSourceType, new()
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
