namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Footnote"/> class from/to OpenXml converter.
/// </summary>
public static class FootnoteConverter
{
  #region Footnote model conversion.
  public static DMW.Footnote? CreateModelElement(DXW.Footnote? openXmlElement)
  {
    return FootnoteEndnoteTypeConverter.CreateModelElement<DMW.Footnote>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.Footnote? openXmlElement, DMW.Footnote? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return FootnoteEndnoteTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.Footnote CreateOpenXmlElement(DMW.Footnote model)
  {
    return FootnoteEndnoteTypeConverter.CreateOpenXmlElement<DXW.Footnote>(model);
  }

  public static bool UpdateOpenXmlElement(DXW.Footnote openXmlElement, DMW.Footnote model)
  {
    return FootnoteEndnoteTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
