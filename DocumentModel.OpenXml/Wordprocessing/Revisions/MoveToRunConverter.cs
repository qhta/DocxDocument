namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.MoveToRun"/> class from/to OpenXml converter.
/// </summary>
public static class MoveToRunConverter
{
  public static DMW.MoveToRun? CreateModelElement(DXW.MoveToRun? openXmlElement)
  {
    return RunTrackChangeTypeConverter.CreateModelElement<DMW.MoveToRun>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXW.MoveToRun? openXmlElement, DMW.MoveToRun? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return RunTrackChangeTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveToRun model)
    where OpenXmlElementType: DXW.MoveToRun, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.MoveToRun openXmlElement, DMW.MoveToRun model)
  {
    return RunTrackChangeTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
