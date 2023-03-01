namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Accent.
/// </summary>
public static class AccentConverter
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  private static DMMath.AccentProperties? GetAccentProperties(DXMath.Accent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.AccentProperties>();
    if (element != null)
      return DMXMath.AccentPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccentProperties(DXMath.Accent openXmlElement, DMMath.AccentProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.AccentProperties>(), value, diffs, objName);
  }
  
  private static void SetAccentProperties(DXMath.Accent openXmlElement, DMMath.AccentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AccentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentPropertiesConverter.CreateOpenXmlElement<DXMath.AccentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Accent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Accent openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.Accent openXmlElement, DMMath.Base? value)
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
  
  public static DocumentModel.Math.Accent? CreateModelElement(DXMath.Accent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Accent();
      value.AccentProperties = GetAccentProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Accent? openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAccentProperties(openXmlElement, value.AccentProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Accent value)
    where OpenXmlElementType: DXMath.Accent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Accent openXmlElement, DMMath.Accent value)
  {
    SetAccentProperties(openXmlElement, value?.AccentProperties);
    SetBase(openXmlElement, value?.Base);
  }
}
