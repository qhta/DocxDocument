using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Normal AutoFit.
/// </summary>
public static class NormalAutoFitConverter
{
  /// <summary>
  ///   Font Scale
  /// </summary>
  public static Int32? GetFontScale(NormalAutoFit? openXmlElement)
  {
    return openXmlElement?.FontScale?.Value;
  }

  public static void SetFontScale(NormalAutoFit? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FontScale = value;
  }

  /// <summary>
  ///   Line Space Reduction
  /// </summary>
  public static Int32? GetLineSpaceReduction(NormalAutoFit? openXmlElement)
  {
    return openXmlElement?.LineSpaceReduction?.Value;
  }

  public static void SetLineSpaceReduction(NormalAutoFit? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineSpaceReduction = value;
  }

  public static DocumentModel.Drawings.NormalAutoFit? CreateModelElement(NormalAutoFit? openXmlElement)
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
    where OpenXmlElementType : NormalAutoFit, new()
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