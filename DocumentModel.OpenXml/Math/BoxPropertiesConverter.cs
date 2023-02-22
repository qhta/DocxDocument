namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Box Properties.
/// </summary>
public static class BoxPropertiesConverter
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  private static DMMath.BooleanKind? GetOperatorEmulator(DXMath.BoxProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.OperatorEmulator>()?.Val?.Value);
  }
  
  private static bool CmpOperatorEmulator(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.OperatorEmulator>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOperatorEmulator(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OperatorEmulator>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.OperatorEmulator, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// No Break.
  /// </summary>
  private static DMMath.BooleanKind? GetNoBreak(DXMath.BoxProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.NoBreak>()?.Val?.Value);
  }
  
  private static bool CmpNoBreak(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.NoBreak>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNoBreak(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.NoBreak>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.NoBreak, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Differential.
  /// </summary>
  private static DMMath.BooleanKind? GetDifferential(DXMath.BoxProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Differential>()?.Val?.Value);
  }
  
  private static bool CmpDifferential(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Differential>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDifferential(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Differential>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.Differential, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Break.
  /// </summary>
  private static DMMath.Break? GetBreak(DXMath.BoxProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Break>();
    if (element != null)
      return DMXMath.BreakConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBreak(DXMath.BoxProperties openXmlElement, DMMath.Break? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Break>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBreak(DXMath.BoxProperties openXmlElement, DMMath.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BreakConverter.CreateOpenXmlElement<DXMath.Break>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  private static DMMath.BooleanKind? GetAlignment(DXMath.BoxProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Alignment>()?.Val?.Value);
  }
  
  private static bool CmpAlignment(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Alignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXMath.BoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Alignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.Alignment, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.BoxProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.BoxProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.BoxProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DocumentModel.Math.BoxProperties? CreateModelElement(DXMath.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BoxProperties();
      value.OperatorEmulator = GetOperatorEmulator(openXmlElement);
      value.NoBreak = GetNoBreak(openXmlElement);
      value.Differential = GetDifferential(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.BoxProperties? openXmlElement, DMMath.BoxProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOperatorEmulator(openXmlElement, value.OperatorEmulator, diffs, objName))
        ok = false;
      if (!CmpNoBreak(openXmlElement, value.NoBreak, diffs, objName))
        ok = false;
      if (!CmpDifferential(openXmlElement, value.Differential, diffs, objName))
        ok = false;
      if (!CmpBreak(openXmlElement, value.Break, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.BoxProperties value)
    where OpenXmlElementType: DXMath.BoxProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.BoxProperties openXmlElement, DMMath.BoxProperties value)
  {
    SetOperatorEmulator(openXmlElement, value?.OperatorEmulator);
    SetNoBreak(openXmlElement, value?.NoBreak);
    SetDifferential(openXmlElement, value?.Differential);
    SetBreak(openXmlElement, value?.Break);
    SetAlignment(openXmlElement, value?.Alignment);
    SetControlProperties(openXmlElement, value?.ControlProperties);
    }
  }
