namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Normal AutoFit.
/// </summary>
public static class NormalAutoFitConverter
{
  /// <summary>
  /// Font Scale
  /// </summary>
  public static Int32? GetFontScale(DocumentFormat.OpenXml.Drawing.NormalAutoFit? openXmlElement)
  {
    return openXmlElement?.FontScale?.Value;
  }
  
  public static void SetFontScale(DocumentFormat.OpenXml.Drawing.NormalAutoFit? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontScale = value;
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  public static Int32? GetLineSpaceReduction(DocumentFormat.OpenXml.Drawing.NormalAutoFit? openXmlElement)
  {
    return openXmlElement?.LineSpaceReduction?.Value;
  }
  
  public static void SetLineSpaceReduction(DocumentFormat.OpenXml.Drawing.NormalAutoFit? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineSpaceReduction = value;
  }
  
  public static DocumentModel.Drawings.NormalAutoFit? CreateModelElement(DocumentFormat.OpenXml.Drawing.NormalAutoFit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NormalAutoFit();
      value.FontScale = GetFontScale(openXmlElement);
      value.LineSpaceReduction = GetLineSpaceReduction(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NormalAutoFit? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NormalAutoFit, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
