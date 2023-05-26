namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.DocPartBody"/> class from/to OpenXml converter.
/// </summary>
public static class DocPartBodyConverter
{
  #region DocPartBody conversion
  public static DMW.DocPartBody? CreateModelElement(DXW.DocPartBody? openXmlElement)
  {
    return BodyTypeConverter.CreateModelElement<DMW.DocPartBody>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.DocPartBody? openXmlElement, DMW.DocPartBody? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BodyTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.DocPartBody CreateOpenXmlElement(DMW.DocPartBody value)
  {
    return BodyTypeConverter.CreateOpenXmlElement<DXW.DocPartBody>(value);
  }

  public static bool UpdateOpenXmlElement(DXW.DocPartBody openXmlElement, DMW.DocPartBody value)
  {
    return BodyTypeConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}