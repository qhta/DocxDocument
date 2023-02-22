namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ClassificationOutcome Class.
/// </summary>
public static class ClassificationOutcomeConverter
{
  /// <summary>
  /// classificationOutcomeType, this property is only available in Office 2021 and later.
  /// </summary>
  private static DMDraws.ClassificationOutcomeType? GetClassificationOutcomeType(DXO2021DrawDocCls.ClassificationOutcome openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMDraws.ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value);
  }
  
  private static bool CmpClassificationOutcomeType(DXO2021DrawDocCls.ClassificationOutcome openXmlElement, DMDraws.ClassificationOutcomeType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMDraws.ClassificationOutcomeType>(openXmlElement?.ClassificationOutcomeType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetClassificationOutcomeType(DXO2021DrawDocCls.ClassificationOutcome openXmlElement, DMDraws.ClassificationOutcomeType? value)
  {
    openXmlElement.ClassificationOutcomeType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcomeType, DMDraws.ClassificationOutcomeType>(value);
  }
  
  public static DocumentModel.Drawings.ClassificationOutcome? CreateModelElement(DXO2021DrawDocCls.ClassificationOutcome? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ClassificationOutcome();
      value.ClassificationOutcomeType = GetClassificationOutcomeType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawDocCls.ClassificationOutcome? openXmlElement, DMDraws.ClassificationOutcome? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpClassificationOutcomeType(openXmlElement, value.ClassificationOutcomeType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ClassificationOutcome value)
    where OpenXmlElementType: DXO2021DrawDocCls.ClassificationOutcome, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DrawDocCls.ClassificationOutcome openXmlElement, DMDraws.ClassificationOutcome value)
  {
    SetClassificationOutcomeType(openXmlElement, value?.ClassificationOutcomeType);
    }
  }
