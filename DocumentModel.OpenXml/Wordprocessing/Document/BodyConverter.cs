namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Body"/> class from/to OpenXml converter.
/// </summary>
public static class BodyConverter
{
  #region Body conversion
  public static DMW.Body? CreateModelElement(DXW.Body? openXmlElement)
  {
    return BodyTypeConverter.CreateModelElement<DMW.Body>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.Body? openXmlElement, DMW.Body? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BodyTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.Body CreateOpenXmlElement(DMW.Body value)
  {
    return BodyTypeConverter.CreateOpenXmlElement<DXW.Body>(value);
  }

  public static bool UpdateOpenXmlElement(DXW.Body openXmlElement, DMW.Body value)
  {
    return BodyTypeConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
