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
    return openXmlElement.FontScale?.Value;
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
    return openXmlElement.LineSpaceReduction?.Value;
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
