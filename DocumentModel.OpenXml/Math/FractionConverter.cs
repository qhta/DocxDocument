namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Fraction Function.
/// </summary>
public static class FractionConverter
{
  /// <summary>
  /// Fraction Properties.
  /// </summary>
  private static DMMath.FractionProperties? GetFractionProperties(DXMath.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.FractionProperties>();
    if (itemElement != null)
      return DMXMath.FractionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFractionProperties(DXMath.Fraction openXmlElement, DMMath.FractionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FractionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionPropertiesConverter.CreateOpenXmlElement<DXMath.FractionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numerator.
  /// </summary>
  private static DMMath.Numerator? GetNumerator(DXMath.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Numerator>();
    if (itemElement != null)
      return DMXMath.NumeratorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumerator(DXMath.Fraction openXmlElement, DMMath.Numerator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Numerator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NumeratorConverter.CreateOpenXmlElement<DXMath.Numerator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Denominator.
  /// </summary>
  private static DMMath.Denominator? GetDenominator(DXMath.Fraction openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Denominator>();
    if (itemElement != null)
      return DMXMath.DenominatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDenominator(DXMath.Fraction openXmlElement, DMMath.Denominator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Denominator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DenominatorConverter.CreateOpenXmlElement<DXMath.Denominator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.Fraction? CreateModelElement(DXMath.Fraction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Fraction();
      value.FractionProperties = GetFractionProperties(openXmlElement);
      value.Numerator = GetNumerator(openXmlElement);
      value.Denominator = GetDenominator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Fraction? value)
    where OpenXmlElementType: DXMath.Fraction, new()
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
