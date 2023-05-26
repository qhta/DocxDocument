namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Fraction"/> class from/to OpenXml converter.
/// </summary>
public static class FractionConverter
{
  #region Fraction Properties. conversion.
  private static DMM.FractionProperties? GetFractionProperties(DXM.Fraction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.FractionProperties>();
    if (element != null)
      return DMXM.FractionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFractionProperties(DXM.Fraction openXmlElement, DMM.FractionProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.FractionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.FractionProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetFractionProperties(DXM.Fraction openXmlElement, DMM.FractionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.FractionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.FractionPropertiesConverter.CreateOpenXmlElement<DXM.FractionProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Numerator conversion.
  private static DMM.Numerator? GetNumerator(DXM.Fraction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Numerator>();
    if (element != null)
      return DMXM.NumeratorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumerator(DXM.Fraction openXmlElement, DMM.Numerator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.NumeratorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Numerator>(), value, diffs, objName, propName);
  }
  
  private static void SetNumerator(DXM.Fraction openXmlElement, DMM.Numerator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Numerator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.NumeratorConverter.CreateOpenXmlElement<DXM.Numerator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Denominator conversion.
  private static DMM.Denominator? GetDenominator(DXM.Fraction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Denominator>();
    if (element != null)
      return DMXM.DenominatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDenominator(DXM.Fraction openXmlElement, DMM.Denominator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.DenominatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Denominator>(), value, diffs, objName, propName);
  }
  
  private static void SetDenominator(DXM.Fraction openXmlElement, DMM.Denominator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Denominator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.DenominatorConverter.CreateOpenXmlElement<DXM.Denominator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Fraction model conversion.
  public static DMM.Fraction? CreateModelElement(DXM.Fraction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Fraction();
      model.FractionProperties = GetFractionProperties(openXmlElement);
      model.Numerator = GetNumerator(openXmlElement);
      model.Denominator = GetDenominator(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Fraction? openXmlElement, DMM.Fraction? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFractionProperties(openXmlElement, model.FractionProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNumerator(openXmlElement, model.Numerator, diffs, objName, propName))
        ok = false;
      if (!CmpDenominator(openXmlElement, model.Denominator, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Fraction CreateOpenXmlElement(DMM.Fraction model)
  {
    var openXmlElement = new DXM.Fraction();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Fraction openXmlElement, DMM.Fraction model)
  {
    SetFractionProperties(openXmlElement, model?.FractionProperties);
    SetNumerator(openXmlElement, model?.Numerator);
    SetDenominator(openXmlElement, model?.Denominator);
    return true;
  }
  #endregion
}
