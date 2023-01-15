using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using ProofState = DocumentFormat.OpenXml.Wordprocessing.ProofState;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Spelling and Grammatical Checking State.
/// </summary>
public static class ProofStateConverter
{
  /// <summary>
  ///   Spell Checking State
  /// </summary>
  public static ProofingStateKind? GetSpelling(ProofState? openXmlElement)
  {
    return EnumValueConverter.GetValue<ProofingStateValues, ProofingStateKind>(openXmlElement?.Spelling?.Value);
  }

  public static void SetSpelling(ProofState? openXmlElement, ProofingStateKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Spelling = EnumValueConverter.CreateEnumValue<ProofingStateValues, ProofingStateKind>(value);
  }

  /// <summary>
  ///   Grammatical Checking State
  /// </summary>
  public static ProofingStateKind? GetGrammar(ProofState? openXmlElement)
  {
    return EnumValueConverter.GetValue<ProofingStateValues, ProofingStateKind>(openXmlElement?.Grammar?.Value);
  }

  public static void SetGrammar(ProofState? openXmlElement, ProofingStateKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Grammar = EnumValueConverter.CreateEnumValue<ProofingStateValues, ProofingStateKind>(value);
  }

  public static DocumentModel.Wordprocessing.ProofState? CreateModelElement(ProofState? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ProofState();
      value.Spelling = GetSpelling(openXmlElement);
      value.Grammar = GetGrammar(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ProofState? value)
    where OpenXmlElementType : ProofState, new()
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