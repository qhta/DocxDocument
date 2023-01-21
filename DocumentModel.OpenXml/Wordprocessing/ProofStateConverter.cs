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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Spelling?.Value);
  }
  
  private static void SetSpelling(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value)
  {
    openXmlElement.Spelling = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DMW.ProofingStateKind>(value);
  }
  
  /// <summary>
  /// Grammatical Checking State
  /// </summary>
  private static DMW.ProofingStateKind? GetGrammar(DXW.ProofState openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DMW.ProofingStateKind>(openXmlElement?.Grammar?.Value);
  }
  
  private static void SetGrammar(DXW.ProofState openXmlElement, DMW.ProofingStateKind? value)
  {
    openXmlElement.Grammar = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingStateValues, DMW.ProofingStateKind>(value);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ProofState? value)
    where OpenXmlElementType: DXW.ProofState, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpelling(openXmlElement, value?.Spelling);
      SetGrammar(openXmlElement, value?.Grammar);
      return openXmlElement;
    }
    return default;
  }
}
