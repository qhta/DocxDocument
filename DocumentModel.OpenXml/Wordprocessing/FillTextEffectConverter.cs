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
    return openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>() != null;
  }
  
  private static bool CmpNoFillEmpty(DXO2010W.FillTextEffect openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010W.NoFillEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010W.NoFillEmpty", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2010W.SolidColorFillProperties>();
    if (element != null)
      return DMXW.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidColorFillProperties(DXO2010W.FillTextEffect openXmlElement, DMW.SolidColorFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.SolidColorFillProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2010W.GradientFillProperties>();
    if (element != null)
      return DMXW.GradientFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFillProperties(DXO2010W.FillTextEffect openXmlElement, DMW.GradientFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.GradientFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.GradientFillProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.FillTextEffect? CreateModelElement(DXO2010W.FillTextEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FillTextEffect();
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.FillTextEffect? openXmlElement, DMW.FillTextEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoFillEmpty(openXmlElement, value.NoFillEmpty, diffs, objName))
        ok = false;
      if (!CmpSolidColorFillProperties(openXmlElement, value.SolidColorFillProperties, diffs, objName))
        ok = false;
      if (!CmpGradientFillProperties(openXmlElement, value.GradientFillProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FillTextEffect value)
    where OpenXmlElementType: DXO2010W.FillTextEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.FillTextEffect openXmlElement, DMW.FillTextEffect value)
  {
    SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
    SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
    SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
    }
  }
