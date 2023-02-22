namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartTextConverter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXDrawCharts.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (element != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringReference(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringReference? value)
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
  private static DMDrawsCharts.RichText? GetRichText(DXDrawCharts.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.RichText>();
    if (element != null)
      return DMXDrawsCharts.RichTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichText(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.RichText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RichTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.RichText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRichText(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.RichText? value)
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
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXDrawCharts.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (element != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringLiteral(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value)
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
  
  public static DocumentModel.Drawings.Charts.ChartText? CreateModelElement(DXDrawCharts.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartText();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartText? openXmlElement, DMDrawsCharts.ChartText? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartText value)
    where OpenXmlElementType: DXDrawCharts.ChartText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.ChartText value)
  {
    SetStringReference(openXmlElement, value?.StringReference);
    SetRichText(openXmlElement, value?.RichText);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
