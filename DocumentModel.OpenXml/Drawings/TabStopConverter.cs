namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Position
  /// </summary>
  private static Int32? GetPosition(DXD.TabStop openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXD.TabStop openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXD.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  private static DMD.TextTabAlignmentKind? GetAlignment(DXD.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DMD.TextTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXD.TabStop openXmlElement, DMD.TextTabAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DMD.TextTabAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXD.TabStop openXmlElement, DMD.TextTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DMD.TextTabAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.TabStop? CreateModelElement(DXD.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStop();
      value.Position = GetPosition(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.TabStop? openXmlElement, DMD.TabStop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TabStop value)
    where OpenXmlElementType: DXD.TabStop, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TabStop openXmlElement, DMD.TabStop value)
  {
    SetPosition(openXmlElement, value?.Position);
    SetAlignment(openXmlElement, value?.Alignment);
  }
}
