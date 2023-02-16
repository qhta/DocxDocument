namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ProofError Class.
/// </summary>
public static class ProofErrorConverter
{
  /// <summary>
  /// Proofing Error Anchor Type
  /// </summary>
  private static DMW.ProofingErrorKind? GetType(DXW.ProofError openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DMW.ProofingErrorKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.ProofError openXmlElement, DMW.ProofingErrorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DMW.ProofingErrorKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXW.ProofError openXmlElement, DMW.ProofingErrorKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DMW.ProofingErrorKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.ProofError? CreateModelElement(DXW.ProofError? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ProofError();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ProofError? openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ProofError? value)
    where OpenXmlElementType: DXW.ProofError, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
