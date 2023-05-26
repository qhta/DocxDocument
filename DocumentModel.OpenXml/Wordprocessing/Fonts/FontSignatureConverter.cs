namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.FontSignature"/> class from/to OpenXml converter.
/// </summary>
public static class FontSignatureConverter
{
  #region First 32 Bits of Unicode Subset Bitfield conversion.
  private static DM.HexInt GetUnicodeSignature0(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature0?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.UnicodeSignature0.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpUnicodeSignature0(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.UnicodeSignature0?.Value, value, diffs, objName, "UnicodeSignature0");
  }
  
  private static void SetUnicodeSignature0(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.UnicodeSignature0 = value.ToString();
    else
      openXmlElement.UnicodeSignature0 = null;
  }
  #endregion

  #region Second 32 Bits of Unicode Subset Bitfield conversion.
  private static DM.HexInt GetUnicodeSignature1(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature1?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.UnicodeSignature1.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpUnicodeSignature1(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.UnicodeSignature1?.Value, value, diffs, objName, "UnicodeSignature1");
  }
  
  private static void SetUnicodeSignature1(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.UnicodeSignature1 = value.ToString();
    else
      openXmlElement.UnicodeSignature1 = null;
  }
  #endregion

  #region Third 32 Bits of Unicode Subset Bitfield conversion.
  private static DM.HexInt GetUnicodeSignature2(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature2?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.UnicodeSignature2.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpUnicodeSignature2(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.UnicodeSignature2?.Value, value, diffs, objName, "UnicodeSignature2");
  }
  
  private static void SetUnicodeSignature2(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.UnicodeSignature2 = value.ToString();
    else
      openXmlElement.UnicodeSignature2 = null;
  }
  #endregion

  #region Fourth 32 Bits of Unicode Subset Bitfield conversion.
  private static DM.HexInt GetUnicodeSignature3(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.UnicodeSignature3?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.UnicodeSignature3.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpUnicodeSignature3(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.UnicodeSignature3?.Value, value, diffs, objName, "UnicodeSignature3");
  }
  
  private static void SetUnicodeSignature3(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.UnicodeSignature3 = value.ToString();
    else
      openXmlElement.UnicodeSignature3 = null;
  }
  #endregion

  #region Lower 32 Bits of Code Page Bit Field conversion.
  private static DM.HexInt GetCodePageSignature0(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.CodePageSignature0?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.CodePageSignature0.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpCodePageSignature0(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.CodePageSignature0?.Value, value, diffs, objName, "CodePageSignature0");
  }
  
  private static void SetCodePageSignature0(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.CodePageSignature0 = value.ToString();
    else
      openXmlElement.CodePageSignature0 = null;
  }
  #endregion

  #region Upper 32 Bits of Code Page Bit Field conversion.
  private static DM.HexInt GetCodePageSignature1(DXW.FontSignature openXmlElement)
  {
    if (openXmlElement?.CodePageSignature1?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.CodePageSignature1.Value) ?? 0;
    return 0;
  }
  
  private static bool CmpCodePageSignature1(DXW.FontSignature openXmlElement, DM.HexInt? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HexIntConverter.CmpValue(openXmlElement?.CodePageSignature1?.Value, value, diffs, objName, "CodePageSignature1");
  }
  
  private static void SetCodePageSignature1(DXW.FontSignature openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.CodePageSignature1 = value.ToString();
    else
      openXmlElement.CodePageSignature1 = null;
  }
  #endregion

  #region FontSignature model conversion.
  public static DMW.FontSignature? CreateModelElement(DXW.FontSignature? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.FontSignature();
      model.UnicodeSignature0 = GetUnicodeSignature0(openXmlElement);
      model.UnicodeSignature1 = GetUnicodeSignature1(openXmlElement);
      model.UnicodeSignature2 = GetUnicodeSignature2(openXmlElement);
      model.UnicodeSignature3 = GetUnicodeSignature3(openXmlElement);
      model.CodePageSignature0 = GetCodePageSignature0(openXmlElement);
      model.CodePageSignature1 = GetCodePageSignature1(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FontSignature? openXmlElement, DMW.FontSignature? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpUnicodeSignature0(openXmlElement, model.UnicodeSignature0, diffs, objName, propName))
        ok = false;
      if (!CmpUnicodeSignature1(openXmlElement, model.UnicodeSignature1, diffs, objName, propName))
        ok = false;
      if (!CmpUnicodeSignature2(openXmlElement, model.UnicodeSignature2, diffs, objName, propName))
        ok = false;
      if (!CmpUnicodeSignature3(openXmlElement, model.UnicodeSignature3, diffs, objName, propName))
        ok = false;
      if (!CmpCodePageSignature0(openXmlElement, model.CodePageSignature0, diffs, objName, propName))
        ok = false;
      if (!CmpCodePageSignature1(openXmlElement, model.CodePageSignature1, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FontSignature model)
    where OpenXmlElementType: DXW.FontSignature, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FontSignature openXmlElement, DMW.FontSignature model)
  {
    SetUnicodeSignature0(openXmlElement, model?.UnicodeSignature0);
    SetUnicodeSignature1(openXmlElement, model?.UnicodeSignature1);
    SetUnicodeSignature2(openXmlElement, model?.UnicodeSignature2);
    SetUnicodeSignature3(openXmlElement, model?.UnicodeSignature3);
    SetCodePageSignature0(openXmlElement, model?.CodePageSignature0);
    SetCodePageSignature1(openXmlElement, model?.CodePageSignature1);
  }
  #endregion
}
