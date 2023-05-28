namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartTextConverter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDC.StringReference? GetStringReference(DXDC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringReference>();
    if (element != null)
      return DMXDC.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDC.ChartText openXmlElement, DMDC.StringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName, propName);
  }
  
  private static void SetStringReference(DXDC.ChartText openXmlElement, DMDC.StringReference? value)
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
  private static DMDC.RichText? GetRichText(DXDC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.RichText>();
    if (element != null)
      return DMXDC.RichTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichText(DXDC.ChartText openXmlElement, DMDC.RichText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.RichTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.RichText>(), value, diffs, objName, propName);
  }
  
  private static void SetRichText(DXDC.ChartText openXmlElement, DMDC.RichText? value)
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
  private static DMDC.StringLiteral? GetStringLiteral(DXDC.ChartText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringLiteral>();
    if (element != null)
      return DMXDC.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXDC.ChartText openXmlElement, DMDC.StringLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringLiteral>(), value, diffs, objName, propName);
  }
  
  private static void SetStringLiteral(DXDC.ChartText openXmlElement, DMDC.StringLiteral? value)
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
  
  public static DMD.Charts.ChartText? CreateModelElement(DXDC.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.ChartText();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartText? openXmlElement, DMDC.ChartText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartText value)
    where OpenXmlElementType: DXDC.ChartText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartText openXmlElement, DMDC.ChartText value)
  {
    SetStringReference(openXmlElement, value?.StringReference);
    SetRichText(openXmlElement, value?.RichText);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
