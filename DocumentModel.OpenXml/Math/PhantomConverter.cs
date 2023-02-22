namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public static class PhantomConverter
{
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  private static DMMath.PhantomProperties? GetPhantomProperties(DXMath.Phantom openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.PhantomProperties>();
    if (element != null)
      return DMXMath.PhantomPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantomProperties(DXMath.Phantom openXmlElement, DMMath.PhantomProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.PhantomProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPhantomProperties(DXMath.Phantom openXmlElement, DMMath.PhantomProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PhantomProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomPropertiesConverter.CreateOpenXmlElement<DXMath.PhantomProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Phantom openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Phantom openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.Phantom openXmlElement, DMMath.Base? value)
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
  
  public static DocumentModel.Math.Phantom? CreateModelElement(DXMath.Phantom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Phantom();
      value.PhantomProperties = GetPhantomProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Phantom? openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPhantomProperties(openXmlElement, value.PhantomProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Phantom value)
    where OpenXmlElementType: DXMath.Phantom, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Phantom openXmlElement, DMMath.Phantom value)
  {
    SetPhantomProperties(openXmlElement, value?.PhantomProperties);
    SetBase(openXmlElement, value?.Base);
    }
  }
