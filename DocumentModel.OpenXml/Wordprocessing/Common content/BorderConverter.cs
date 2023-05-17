using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DMW.BorderKind? GetVal(DXW.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.BorderValues, DMW.BorderKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.BorderType openXmlElement, DMW.BorderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.BorderValues, DMW.BorderKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.BorderType openXmlElement, DMW.BorderKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.BorderValues, DMW.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static Twips? GetSize(DXW.BorderType openXmlElement)
  {
    if (openXmlElement?.Size?.Value!=null)
      return new Twips(openXmlElement.Size.Value*5);
    return null;
  }
  
  private static bool CmpSize(DXW.BorderType openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value/5) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXW.BorderType openXmlElement, Twips? value)
  {
    if (value is not null)
      openXmlElement.Size = ((uint)value)/5;
    else
      openXmlElement.Size = null;
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  private static Twips? GetSpace(DXW.BorderType openXmlElement)
  {
    if (openXmlElement?.Space?.Value!=null)
      return new Twips(openXmlElement.Space.Value*5);
    return null;
  }
  
  private static bool CmpSpace(DXW.BorderType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Space?.Value == value/5) return true;
    diffs?.Add(objName, "Space", openXmlElement?.Space?.Value, value);
    return false;
  }
  
  private static void SetSpace(DXW.BorderType openXmlElement, UInt32? value)
  {
    if (value is not null)
      openXmlElement.Space = ((uint)value)/5;
    else
      openXmlElement.Space = null;
  }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  private static Boolean? GetShadow(DXW.BorderType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Shadow);
  }
  
  private static bool CmpShadow(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Shadow, value, diffs, objName, "Shadow");
  }
  
  private static void SetShadow(DXW.BorderType openXmlElement, Boolean? value)
  {
    openXmlElement.Shadow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  private static Boolean? GetFrame(DXW.BorderType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Frame);
  }
  
  private static bool CmpFrame(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Frame, value, diffs, objName, "Frame");
  }
  
  private static void SetFrame(DXW.BorderType openXmlElement, Boolean? value)
  {
    openXmlElement.Frame = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.Border? CreateModelElement(DXW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Border();
      value.Type = GetVal(openXmlElement);
      value.Color = BorderTypeColorConverter.CreateModelElement(openXmlElement);
      value.Width = GetSize(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BorderType? openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!BorderTypeColorConverter.CompareModelElement(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpFrame(openXmlElement, value.Frame, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Border value)
    where OpenXmlElementType: DXW.BorderType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.BorderType openXmlElement, DMW.Border value)
  {
    SetVal(openXmlElement, value.Type);
    BorderTypeColorConverter.UpdateOpenXmlElement(openXmlElement, value.Color);
    SetSize(openXmlElement, value.Width);
    SetSpace(openXmlElement, value.Space);
    SetShadow(openXmlElement, value.Shadow);
    SetFrame(openXmlElement, value.Frame);
  }
}
