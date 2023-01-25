namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Normal AutoFit.
/// </summary>
public static class NormalAutoFitConverter
{
  /// <summary>
  /// Font Scale
  /// </summary>
  private static Int32? GetFontScale(DXDraw.NormalAutoFit openXmlElement)
  {
    return openXmlElement?.FontScale?.Value;
  }
  
  private static bool CmpFontScale(DXDraw.NormalAutoFit openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FontScale?.Value == value) return true;
    diffs?.Add(objName, "FontScale", openXmlElement?.FontScale?.Value, value);
    return false;
  }
  
  private static void SetFontScale(DXDraw.NormalAutoFit openXmlElement, Int32? value)
  {
    openXmlElement.FontScale = value;
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  private static Int32? GetLineSpaceReduction(DXDraw.NormalAutoFit openXmlElement)
  {
    return openXmlElement?.LineSpaceReduction?.Value;
  }
  
  private static bool CmpLineSpaceReduction(DXDraw.NormalAutoFit openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LineSpaceReduction?.Value == value) return true;
    diffs?.Add(objName, "LineSpaceReduction", openXmlElement?.LineSpaceReduction?.Value, value);
    return false;
  }
  
  private static void SetLineSpaceReduction(DXDraw.NormalAutoFit openXmlElement, Int32? value)
  {
    openXmlElement.LineSpaceReduction = value;
  }
  
  public static DMDraws.NormalAutoFit? CreateModelElement(DXDraw.NormalAutoFit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NormalAutoFit();
      value.FontScale = GetFontScale(openXmlElement);
      value.LineSpaceReduction = GetLineSpaceReduction(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NormalAutoFit? openXmlElement, DMDraws.NormalAutoFit? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFontScale(openXmlElement, value.FontScale, diffs, objName))
        ok = false;
      if (!CmpLineSpaceReduction(openXmlElement, value.LineSpaceReduction, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NormalAutoFit? value)
    where OpenXmlElementType: DXDraw.NormalAutoFit, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFontScale(openXmlElement, value?.FontScale);
      SetLineSpaceReduction(openXmlElement, value?.LineSpaceReduction);
      return openXmlElement;
    }
    return default;
  }
}
