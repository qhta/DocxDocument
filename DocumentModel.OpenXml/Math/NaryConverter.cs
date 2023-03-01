namespace DocumentModel.OpenXml.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public static class NaryConverter
{
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  private static DMMath.NaryProperties? GetNaryProperties(DXMath.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.NaryProperties>();
    if (element != null)
      return DMXMath.NaryPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNaryProperties(DXMath.Nary openXmlElement, DMMath.NaryProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.NaryProperties>(), value, diffs, objName);
  }
  
  private static void SetNaryProperties(DXMath.Nary openXmlElement, DMMath.NaryProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NaryProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryPropertiesConverter.CreateOpenXmlElement<DXMath.NaryProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  private static DMMath.SubArgument? GetSubArgument(DXMath.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (element != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXMath.Nary openXmlElement, DMMath.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubArgument>(), value, diffs, objName);
  }
  
  private static void SetSubArgument(DXMath.Nary openXmlElement, DMMath.SubArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubArgumentConverter.CreateOpenXmlElement<DXMath.SubArgument>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  private static DMMath.SuperArgument? GetSuperArgument(DXMath.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (element != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXMath.Nary openXmlElement, DMMath.SuperArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SuperArgument>(), value, diffs, objName);
  }
  
  private static void SetSuperArgument(DXMath.Nary openXmlElement, DMMath.SuperArgument? value)
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
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Nary openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.Nary openXmlElement, DMMath.Base? value)
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
  
  public static DocumentModel.Math.Nary? CreateModelElement(DXMath.Nary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Nary();
      value.NaryProperties = GetNaryProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Nary? openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNaryProperties(openXmlElement, value.NaryProperties, diffs, objName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, value.SubArgument, diffs, objName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, value.SuperArgument, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXMath.Nary CreateOpenXmlElement(DMMath.Nary value)
  {
    var openXmlElement = new DXMath.Nary();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Nary openXmlElement, DMMath.Nary value)
  {
    SetNaryProperties(openXmlElement, value?.NaryProperties);
    SetSubArgument(openXmlElement, value?.SubArgument);
    SetSuperArgument(openXmlElement, value?.SuperArgument);
    SetBase(openXmlElement, value?.Base);
  }
}
