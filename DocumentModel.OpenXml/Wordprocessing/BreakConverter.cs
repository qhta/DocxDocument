using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Break converte converter from/to OpenXml.
///</summary>
public static class BreakConverter
{
  #region BreakKind conversion
  private static DMW.BreakKind? GetType(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value);
  }

  private static bool CmpType(DXW.Break openXmlElement, DMW.BreakKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetType(DXW.Break openXmlElement, DMW.BreakKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakValues, DMW.BreakKind>(value);
  }

  #endregion

  #region BreakTextStartLocationKind conversion
  private static DMW.BreakTextRestartLocationKind? GetClear(DXW.Break openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value);
  }

  private static bool CmpClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(openXmlElement?.Clear?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetClear(DXW.Break openXmlElement, DMW.BreakTextRestartLocationKind? value)
  {
    openXmlElement.Clear = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues, DMW.BreakTextRestartLocationKind>(value);
  }
  #endregion

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

  public static DMW.Break? CreateModelElement(DXW.LastRenderedPageBreak? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Break();
      value.Type = DMW.BreakKind.Page;
      value.IsLastRendered = true;
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Break? openXmlElement, DMW.Break? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpClear(openXmlElement, value.Clear, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.LastRenderedPageBreak? openXmlElement, DMW.Break? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.BreakKind>(DMW.BreakKind.Page, value.Type, diffs, objName, "Page"))
        ok = false;
      if (!BooleanValueConverter.CmpValue(true, value.IsLastRendered, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Break value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    return openXmlElement;
  }

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.Break value)
  {
    if (value.IsLastRendered)
      return CreateOpenXmlElement<DXW.LastRenderedPageBreak>(value);
    else
    {
      var openXmlElement = CreateOpenXmlElement<DXW.Break>(value);
      UpdateOpenXmlElement(openXmlElement, value);
      return openXmlElement;
    }
  }

  public static bool UpdateOpenXmlElement(DXW.Break openXmlElement, DMW.Break value)
  {
    SetType(openXmlElement, value.Type);
    SetClear(openXmlElement, value.Clear);
    return true;
  }

    public static bool UpdateOpenXmlElement(DXW.LastRenderedPageBreak openXmlElement, DMW.Break value)
  {
    return true;
  }
}
