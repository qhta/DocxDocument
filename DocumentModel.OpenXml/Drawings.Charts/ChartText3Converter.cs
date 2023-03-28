namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class converter from/to OpenXml.
///</summary>
public static class ChartText3Converter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXO2013DrawChart.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (element != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringReference>(), value, diffs, objName);
  }
  
  private static void SetStringReference(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringReference? value)
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
  /// Rich Text.
  /// </summary>
  private static DMDrawsCharts.RichText? GetRichText(DXO2013DrawChart.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.RichText>();
    if (element != null)
      return DMXDrawsCharts.RichTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichText(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.RichText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RichTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.RichText>(), value, diffs, objName);
  }
  
  private static void SetRichText(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.RichText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RichText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RichTextConverter.CreateOpenXmlElement<DXDrawCharts.RichText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXO2013DrawChart.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (element != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>(), value, diffs, objName);
  }
  
  private static void SetStringLiteral(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value)
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
  
  public static DocumentModel.Drawings.Charts.ChartText3? CreateModelElement(DXO2013DrawChart.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartText3();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.ChartText? openXmlElement, DMDrawsCharts.ChartText3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName))
        ok = false;
      if (!CmpRichText(openXmlElement, value.RichText, diffs, objName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartText3 value)
    where OpenXmlElementType: DXO2013DrawChart.ChartText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.ChartText3 value)
  {
    SetStringReference(openXmlElement, value?.StringReference);
    SetRichText(openXmlElement, value?.RichText);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
