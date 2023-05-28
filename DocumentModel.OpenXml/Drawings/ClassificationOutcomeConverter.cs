namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public static class ClassificationOutcomeConverter
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  private static DMD.ClassificationOutcomeType? GetClassificationOutcomeType(DXO21DDC.ClassificationOutcome openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMD.ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value);
  }
  
  private static bool CmpClassificationOutcomeType(DXO21DDC.ClassificationOutcome openXmlElement, DMD.ClassificationOutcomeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMD.ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetClassificationOutcomeType(DXO21DDC.ClassificationOutcome openXmlElement, DMD.ClassificationOutcomeType? value)
  {
    openXmlElement.ClassificationOutcomeType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMD.ClassificationOutcomeType>(value);
  }
  
  public static DMD.ClassificationOutcome? CreateModelElement(DXO21DDC.ClassificationOutcome? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ClassificationOutcome();
      value.ClassificationOutcomeType = GetClassificationOutcomeType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DDC.ClassificationOutcome? openXmlElement, DMD.ClassificationOutcome? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationOutcomeType(openXmlElement, value.ClassificationOutcomeType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ClassificationOutcome value)
    where OpenXmlElementType: DXO21DDC.ClassificationOutcome, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DDC.ClassificationOutcome openXmlElement, DMD.ClassificationOutcome value)
  {
    SetClassificationOutcomeType(openXmlElement, value?.ClassificationOutcomeType);
  }
}
