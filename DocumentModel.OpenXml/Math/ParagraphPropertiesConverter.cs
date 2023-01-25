namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMMath.JustificationKind? GetJustification(DXMath.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(openXmlElement.GetFirstChild<DXMath.Justification>()?.Val?.Value);
  }
  
  private static bool CmpJustification(DXMath.ParagraphProperties openXmlElement, DMMath.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(openXmlElement.GetFirstChild<DXMath.Justification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetJustification(DXMath.ParagraphProperties openXmlElement, DMMath.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Justification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Justification, DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.ParagraphProperties? CreateModelElement(DXMath.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.ParagraphProperties();
      value.Justification = GetJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.ParagraphProperties? openXmlElement, DMMath.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpJustification(openXmlElement, value.Justification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.ParagraphProperties? value)
    where OpenXmlElementType: DXMath.ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetJustification(openXmlElement, value?.Justification);
      return openXmlElement;
    }
    return default;
  }
}
