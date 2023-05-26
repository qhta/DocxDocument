namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.InsertedRun"/> class from/to OpenXml converter.
/// </summary>
public static class InsertedRunConverter
{
  public static DMW.InsertedRun? CreateModelElement(DXW.InsertedRun? openXmlElement)
  {
    return RunTrackChangeTypeConverter.CreateModelElement<DMW.InsertedRun>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXW.InsertedRun? openXmlElement, DMW.InsertedRun? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return RunTrackChangeTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.InsertedRun model)
    where OpenXmlElementType: DXW.InsertedRun, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.InsertedRun openXmlElement, DMW.InsertedRun model)
  {
    return RunTrackChangeTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
