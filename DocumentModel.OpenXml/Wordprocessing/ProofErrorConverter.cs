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
  
  private static void SetType(DXW.ProofError openXmlElement, DMW.ProofingErrorKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ProofingErrorValues, DMW.ProofingErrorKind>(value);
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
