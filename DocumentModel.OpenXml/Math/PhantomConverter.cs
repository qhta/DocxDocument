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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PhantomProperties>();
    if (itemElement != null)
      return DMXMath.PhantomPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMMath.Phantom? CreateModelElement(DXMath.Phantom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Phantom();
      value.PhantomProperties = GetPhantomProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Phantom? value)
    where OpenXmlElementType: DXMath.Phantom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPhantomProperties(openXmlElement, value?.PhantomProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
