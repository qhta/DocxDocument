namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Spelling and Grammatical Checking State.
/// </summary>
public static class ProofStateConverter
{
  /// <summary>
  /// Spell Checking State
  /// </summary>
  private static DMW.ProofingStateKind? GetSpelling(DXW.ProofState openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Spelling?.Value);
  }
  
  private static bool CmpSpelling(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Spelling?.Value, value, diffs, objName, propName);
  }
  
  private static void SetSpelling(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value)
  {
    openXmlElement.Spelling = EnumValueConverter.CreateEnumValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(value);
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  private static DMW.ProofingStateKind? GetGrammar(DXW.ProofState openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Grammar?.Value);
  }
  
  private static bool CmpGrammar(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Grammar?.Value, value, diffs, objName, propName);
  }
  
  private static void SetGrammar(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value)
  {
    openXmlElement.Grammar = EnumValueConverter.CreateEnumValue<DXW.ProofingStateValues, DMW.ProofingStateKind>(value);
  }
  
  public static DMW.ProofState? CreateModelElement(DXW.ProofState? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ProofState();
      value.Spelling = GetSpelling(openXmlElement);
      value.Grammar = GetGrammar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ProofState? openXmlElement, DMW.ProofState? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSpelling(openXmlElement, value.Spelling, diffs, objName, propName))
        ok = false;
      if (!CmpGrammar(openXmlElement, value.Grammar, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ProofState value)
    where OpenXmlElementType: DXW.ProofState, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ProofState openXmlElement, DMW.ProofState value)
  {
    SetSpelling(openXmlElement, value?.Spelling);
    SetGrammar(openXmlElement, value?.Grammar);
  }
}
