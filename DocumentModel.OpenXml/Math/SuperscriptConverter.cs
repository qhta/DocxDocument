namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public static class SuperscriptConverter
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  private static DMMath.SuperscriptProperties? GetSuperscriptProperties(DXMath.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SuperscriptProperties>();
    if (element != null)
      return DMXMath.SuperscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscriptProperties(DXMath.Superscript openXmlElement, DMMath.SuperscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SuperscriptProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperscriptProperties(DXMath.Superscript openXmlElement, DMMath.SuperscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SuperscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptPropertiesConverter.CreateOpenXmlElement<DXMath.SuperscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Superscript openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.Superscript openXmlElement, DMMath.Base? value)
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
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  private static DMMath.SuperArgument? GetSuperArgument(DXMath.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (element != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXMath.Superscript openXmlElement, DMMath.SuperArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SuperArgument>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperArgument(DXMath.Superscript openXmlElement, DMMath.SuperArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperArgumentConverter.CreateOpenXmlElement<DXMath.SuperArgument>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Superscript? CreateModelElement(DXMath.Superscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Superscript();
      value.SuperscriptProperties = GetSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Superscript? openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSuperscriptProperties(openXmlElement, value.SuperscriptProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, value.SuperArgument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Superscript value)
    where OpenXmlElementType: DXMath.Superscript, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Superscript openXmlElement, DMMath.Superscript value)
  {
    SetSuperscriptProperties(openXmlElement, value?.SuperscriptProperties);
    SetBase(openXmlElement, value?.Base);
    SetSuperArgument(openXmlElement, value?.SuperArgument);
    }
  }
