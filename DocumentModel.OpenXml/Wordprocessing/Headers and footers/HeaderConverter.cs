namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Header"/> class from/to OpenXml converter.
/// </summary>
public static class HeaderConverter
{
  #region Header model conversion.
  public static DMW.Header? CreateModelElement(DXW.Header? openXmlElement)
  {
    return HeaderFooterConverter.CreateModelElement<DMW.Header>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.Header? openXmlElement, DMW.Header? model, DiffList? diffs, string? objName)
  {
    return HeaderFooterConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }

  public static DXW.Header CreateOpenXmlElement(DMW.Header model)
  {
    return HeaderFooterConverter.CreateOpenXmlElement<DXW.Header>(model);
  }

  public static bool UpdateOpenXmlElement(DXW.Header openXmlElement, DMW.Header model)
  {
    return HeaderFooterConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
