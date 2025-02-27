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
    return EnumValueConverter.GetValue<DXW.ProofingErrorValues, DMW.ProofingErrorKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.ProofError openXmlElement, DMW.ProofingErrorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ProofingErrorValues, DMW.ProofingErrorKind>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXW.ProofError openXmlElement, DMW.ProofingErrorKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.ProofingErrorValues, DMW.ProofingErrorKind>(value);
  }
  
  public static DMW.ProofError? CreateModelElement(DXW.ProofError? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ProofError();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ProofError? openXmlElement, DMW.ProofError? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.ProofError CreateOpenXmlElement(DMW.ProofError value)
  {
    var openXmlElement = new DXW.ProofError();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.ProofError openXmlElement, DMW.ProofError value)
  {
    SetType(openXmlElement, value?.Type);
    return true;
  }
}
