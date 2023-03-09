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
    var element = openXmlElement?.GetFirstChild<DXMath.FractionProperties>();
    if (element != null)
      return DMXMath.FractionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFractionProperties(DXMath.Fraction openXmlElement, DMMath.FractionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.FractionProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXMath.Numerator>();
    if (element != null)
      return DMXMath.NumeratorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumerator(DXMath.Fraction openXmlElement, DMMath.Numerator? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NumeratorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Numerator>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXMath.Denominator>();
    if (element != null)
      return DMXMath.DenominatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDenominator(DXMath.Fraction openXmlElement, DMMath.Denominator? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DenominatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Denominator>(), value, diffs, objName);
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXMath.Fraction CreateOpenXmlElement(DMMath.Fraction value)
  {
    var openXmlElement = new DXMath.Fraction();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Fraction openXmlElement, DMMath.Fraction value)
  {
    SetFractionProperties(openXmlElement, value?.FractionProperties);
    SetNumerator(openXmlElement, value?.Numerator);
    SetDenominator(openXmlElement, value?.Denominator);
  }
}
