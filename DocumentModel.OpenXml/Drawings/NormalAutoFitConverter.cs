namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Normal AutoFit.
/// </summary>
public static class NormalAutoFitConverter
{
  /// <summary>
  /// Font Scale
  /// </summary>
  private static Int32? GetFontScale(DXD.NormalAutoFit openXmlElement)
  {
    return openXmlElement?.FontScale?.Value;
  }
  
  private static bool CmpFontScale(DXD.NormalAutoFit openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FontScale?.Value == value) return true;
    diffs?.Add(objName, "FontScale", openXmlElement?.FontScale?.Value, value);
    return false;
  }
  
  private static void SetFontScale(DXD.NormalAutoFit openXmlElement, Int32? value)
  {
    openXmlElement.FontScale = value;
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  private static Int32? GetLineSpaceReduction(DXD.NormalAutoFit openXmlElement)
  {
    return openXmlElement?.LineSpaceReduction?.Value;
  }
  
  private static bool CmpLineSpaceReduction(DXD.NormalAutoFit openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LineSpaceReduction?.Value == value) return true;
    diffs?.Add(objName, "LineSpaceReduction", openXmlElement?.LineSpaceReduction?.Value, value);
    return false;
  }
  
  private static void SetLineSpaceReduction(DXD.NormalAutoFit openXmlElement, Int32? value)
  {
    openXmlElement.LineSpaceReduction = value;
  }
  
  public static DMD.NormalAutoFit? CreateModelElement(DXD.NormalAutoFit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.NormalAutoFit();
      value.FontScale = GetFontScale(openXmlElement);
      value.LineSpaceReduction = GetLineSpaceReduction(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.NormalAutoFit? openXmlElement, DMD.NormalAutoFit? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFontScale(openXmlElement, value.FontScale, diffs, objName, propName))
        ok = false;
      if (!CmpLineSpaceReduction(openXmlElement, value.LineSpaceReduction, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NormalAutoFit value)
    where OpenXmlElementType: DXD.NormalAutoFit, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NormalAutoFit openXmlElement, DMD.NormalAutoFit value)
  {
    SetFontScale(openXmlElement, value?.FontScale);
    SetLineSpaceReduction(openXmlElement, value?.LineSpaceReduction);
  }
}
