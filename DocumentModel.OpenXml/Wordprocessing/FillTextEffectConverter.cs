namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public static class FillTextEffectConverter
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  private static Boolean? GetNoFillEmpty(DXO2010W.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>();
    return itemElement != null;
  }
  
  private static void SetNoFillEmpty(DXO2010W.FillTextEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010W.NoFillEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  private static DMW.SolidColorFillProperties? GetSolidColorFillProperties(DXO2010W.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (itemElement != null)
      return DMXW.SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidColorFillProperties(DXO2010W.FillTextEffect openXmlElement, DMW.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO2010W.SolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  private static DMW.GradientFillProperties? GetGradientFillProperties(DXO2010W.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (itemElement != null)
      return DMXW.GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFillProperties(DXO2010W.FillTextEffect openXmlElement, DMW.GradientFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.GradientFillPropertiesConverter.CreateOpenXmlElement<DXO2010W.GradientFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.FillTextEffect? CreateModelElement(DXO2010W.FillTextEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FillTextEffect();
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FillTextEffect? value)
    where OpenXmlElementType: DXO2010W.FillTextEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
      SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
      SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
      return openXmlElement;
    }
    return default;
  }
}
