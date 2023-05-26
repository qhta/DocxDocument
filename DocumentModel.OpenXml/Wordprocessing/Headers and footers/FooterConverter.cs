namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Footer"/> class from/to OpenXml converter.
/// </summary>
public static class FooterConverter
{
  #region Footer model conversion.
  public static DMW.Footer? CreateModelElement(DXW.Footer? openXmlElement)
  {
    return HeaderFooterConverter.CreateModelElement<DMW.Footer>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.Footer? openXmlElement, DMW.Footer? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return HeaderFooterConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.Footer CreateOpenXmlElement(DMW.Footer model)
  {
    return HeaderFooterConverter.CreateOpenXmlElement<DXW.Footer>(model);
  }

  public static bool UpdateOpenXmlElement(DXW.Footer openXmlElement, DMW.Footer model)
  {
    return HeaderFooterConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}