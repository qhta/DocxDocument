namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public static class AxisDataSourceType3Converter
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  private static DMDrawsCharts.MultiLevelStringReference? GetMultiLevelStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MultiLevelStringReference>());
  }
  
  private static bool CmpMultiLevelStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.MultiLevelStringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MultiLevelStringReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.MultiLevelStringReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMultiLevelStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.MultiLevelStringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.MultiLevelStringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXO2013DrawChart.AxisDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>());
  }
  
  private static bool CmpNumberReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.NumberReference? value)
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
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>());
  }
  
  private static bool CmpNumberLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.NumberLiteral? value)
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
  
  /// <summary>
  /// StringReference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>());
  }
  
  private static bool CmpStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringReferenceConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringReference(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement)
  {
    return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>());
  }
  
  private static bool CmpStringLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.StringLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringLiteralConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringLiteral(DXO2013DrawChart.AxisDataSourceType openXmlElement, DMDrawsCharts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringLiteralConverter.CreateOpenXmlElement<DXDrawCharts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.AxisDataSourceType3? CreateModelElement(DXO2013DrawChart.AxisDataSourceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AxisDataSourceType3();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.AxisDataSourceType? openXmlElement, DMDrawsCharts.AxisDataSourceType3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLevelStringReference(openXmlElement, value.MultiLevelStringReference, diffs, objName))
        ok = false;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName))
        ok = false;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AxisDataSourceType3? value)
    where OpenXmlElementType: DXO2013DrawChart.AxisDataSourceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      SetStringReference(openXmlElement, value?.StringReference);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}
