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
    return DMXMath.FractionPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.FractionProperties>());
  }
  
  private static bool CmpFractionProperties(DXMath.Fraction openXmlElement, DMMath.FractionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.FractionProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.NumeratorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Numerator>());
  }
  
  private static bool CmpNumerator(DXMath.Fraction openXmlElement, DMMath.Numerator? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NumeratorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Numerator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.DenominatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Denominator>());
  }
  
  private static bool CmpDenominator(DXMath.Fraction openXmlElement, DMMath.Denominator? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DenominatorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Denominator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXMath.Fraction? openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFractionProperties(openXmlElement, value.FractionProperties, diffs, objName))
        ok = false;
      if (!CmpNumerator(openXmlElement, value.Numerator, diffs, objName))
        ok = false;
      if (!CmpDenominator(openXmlElement, value.Denominator, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
