using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Break converter
/// </summary>
public static class BreakConverter
{
  #region BreakKind conversion
  private static DMW.BreakKind? GetType(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value);
  }

  private static bool CmpType(DXW.Break openXmlElement, DMW.BreakKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetType(DXW.Break openXmlElement, DMW.BreakKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.BreakValues, DMW.BreakKind>(value);
  }

  #endregion

  #region BreakTextStartLocationKind conversion
  private static DMW.BreakTextRestartLocationKind? GetClear(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }

  private static bool CmpClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value)
  {
    openXmlElement.Clear = EnumValueConverter.CreateEnumValue<DXW.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(value);
  }
  #endregion

  #region Break model element conversion
  public static DMW.Break? CreateModelElement(DXW.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Break();
      value.Type = GetType(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }

  public static DMW.LastRenderedPageBreak? CreateModelElement(DXW.LastRenderedPageBreak? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LastRenderedPageBreak();
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Break? openXmlElement, DMW.Break? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpClear(openXmlElement, value.Clear, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.Break CreateOpenXmlElement(DMW.Break value)
  {
    var openXmlElement = new DXW.Break();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }


  public static bool UpdateOpenXmlElement(DXW.Break openXmlElement, DMW.Break value)
  {
    SetType(openXmlElement, value.Type);
    SetClear(openXmlElement, value.Clear);
    return true;
  }
  #endregion
}
