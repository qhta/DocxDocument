namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartText3Converter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDC.StringReference? GetStringReference(DXO13DC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringReference>();
    if (element != null)
      return DMXDC.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXO13DC.ChartText openXmlElement, DMDC.StringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName, propName);
  }
  
  private static void SetStringReference(DXO13DC.ChartText openXmlElement, DMDC.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  private static DMDC.RichText? GetRichText(DXO13DC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.RichText>();
    if (element != null)
      return DMXDC.RichTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichText(DXO13DC.ChartText openXmlElement, DMDC.RichText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.RichTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.RichText>(), value, diffs, objName, propName);
  }
  
  private static void SetRichText(DXO13DC.ChartText openXmlElement, DMDC.RichText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.RichText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.RichTextConverter.CreateOpenXmlElement<DXDC.RichText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  private static DMDC.StringLiteral? GetStringLiteral(DXO13DC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringLiteral>();
    if (element != null)
      return DMXDC.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXO13DC.ChartText openXmlElement, DMDC.StringLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringLiteral>(), value, diffs, objName, propName);
  }
  
  private static void SetStringLiteral(DXO13DC.ChartText openXmlElement, DMDC.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringLiteralConverter.CreateOpenXmlElement<DXDC.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartText3? CreateModelElement(DXO13DC.ChartText? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13DC.ChartText? openXmlElement, DMDC.ChartText3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName, propName))
        ok = false;
      if (!CmpRichText(openXmlElement, value.RichText, diffs, objName, propName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartText3 value)
    where OpenXmlElementType: DXO13DC.ChartText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.ChartText openXmlElement, DMDC.ChartText3 value)
  {
    SetStringReference(openXmlElement, value?.StringReference);
    SetRichText(openXmlElement, value?.RichText);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
