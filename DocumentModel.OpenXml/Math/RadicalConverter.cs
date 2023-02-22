namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Radical Function.
/// </summary>
public static class RadicalConverter
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  private static DMMath.RadicalProperties? GetRadicalProperties(DXMath.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.RadicalProperties>();
    if (element != null)
      return DMXMath.RadicalPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadicalProperties(DXMath.Radical openXmlElement, DMMath.RadicalProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.RadicalProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadicalProperties(DXMath.Radical openXmlElement, DMMath.RadicalProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RadicalProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalPropertiesConverter.CreateOpenXmlElement<DXMath.RadicalProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  private static DMMath.Degree? GetDegree(DXMath.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Degree>();
    if (element != null)
      return DMXMath.DegreeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDegree(DXMath.Radical openXmlElement, DMMath.Degree? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DegreeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Degree>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDegree(DXMath.Radical openXmlElement, DMMath.Degree? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Degree>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DegreeConverter.CreateOpenXmlElement<DXMath.Degree>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Radical openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.Radical openXmlElement, DMMath.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Radical? CreateModelElement(DXMath.Radical? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Radical();
      value.RadicalProperties = GetRadicalProperties(openXmlElement);
      value.Degree = GetDegree(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Radical? openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadicalProperties(openXmlElement, value.RadicalProperties, diffs, objName))
        ok = false;
      if (!CmpDegree(openXmlElement, value.Degree, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Radical value)
    where OpenXmlElementType: DXMath.Radical, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Radical openXmlElement, DMMath.Radical value)
  {
    SetRadicalProperties(openXmlElement, value?.RadicalProperties);
    SetDegree(openXmlElement, value?.Degree);
    SetBase(openXmlElement, value?.Base);
    }
  }
