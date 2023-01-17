namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public static class FractionConverter
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  private static DocumentModel.Math.FractionProperties? GetFractionProperties(DocumentFormat.OpenXml.Math.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.FractionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFractionProperties(DocumentFormat.OpenXml.Math.Fraction openXmlElement, DocumentModel.Math.FractionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.FractionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  private static DocumentModel.Math.Numerator? GetNumerator(DocumentFormat.OpenXml.Math.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.NumeratorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumerator(DocumentFormat.OpenXml.Math.Fraction openXmlElement, DocumentModel.Math.Numerator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.NumeratorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Numerator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  private static DocumentModel.Math.Denominator? GetDenominator(DocumentFormat.OpenXml.Math.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.DenominatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDenominator(DocumentFormat.OpenXml.Math.Fraction openXmlElement, DocumentModel.Math.Denominator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.DenominatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Denominator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Fraction? CreateModelElement(DocumentFormat.OpenXml.Math.Fraction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Fraction();
      value.FractionProperties = GetFractionProperties(openXmlElement);
      value.Numerator = GetNumerator(openXmlElement);
      value.Denominator = GetDenominator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Fraction? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Fraction, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFractionProperties(openXmlElement, value?.FractionProperties);
      SetNumerator(openXmlElement, value?.Numerator);
      SetDenominator(openXmlElement, value?.Denominator);
      return openXmlElement;
    }
    return default;
  }
}
