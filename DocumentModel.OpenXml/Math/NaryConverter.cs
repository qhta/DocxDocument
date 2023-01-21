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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.NaryProperties>();
    if (itemElement != null)
      return DMXMath.NaryPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMMath.Nary? CreateModelElement(DXMath.Nary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Nary();
      value.NaryProperties = GetNaryProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Nary? value)
    where OpenXmlElementType: DXMath.Nary, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNaryProperties(openXmlElement, value?.NaryProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
