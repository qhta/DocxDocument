namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Endnote"/> class from/to OpenXml converter.
/// </summary>
public static class EndnoteConverter
{
  #region Endnote model conversion.
  public static DMW.Endnote? CreateModelElement(DXW.Endnote? openXmlElement)
  {
    return FootnoteEndnoteTypeConverter.CreateModelElement<DMW.Endnote>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.Endnote? openXmlElement, DMW.Endnote? model, DiffList? diffs, string? objName)
  {
    return FootnoteEndnoteTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }

  public static DXW.Endnote CreateOpenXmlElement(DMW.Endnote model)
  {
    return FootnoteEndnoteTypeConverter.CreateOpenXmlElement<DXW.Endnote>(model);
  }

  public static bool UpdateOpenXmlElement(DXW.Endnote openXmlElement, DMW.Endnote model)
  {
    return FootnoteEndnoteTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
