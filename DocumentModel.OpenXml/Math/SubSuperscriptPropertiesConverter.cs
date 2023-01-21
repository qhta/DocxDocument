namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public static class SubSuperscriptPropertiesConverter
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  private static DMMath.BooleanKind? GetAlignScripts(DXMath.SubSuperscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AlignScripts>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAlignScripts(DXMath.SubSuperscriptProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AlignScripts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.AlignScripts, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.SubSuperscriptProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DXMath.SubSuperscriptProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.SubSuperscriptProperties? CreateModelElement(DXMath.SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.SubSuperscriptProperties();
      value.AlignScripts = GetAlignScripts(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.SubSuperscriptProperties? value)
    where OpenXmlElementType: DXMath.SubSuperscriptProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignScripts(openXmlElement, value?.AlignScripts);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
