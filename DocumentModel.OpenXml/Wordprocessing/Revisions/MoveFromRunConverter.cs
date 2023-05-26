namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.MoveFromRun"/> class from/to OpenXml converter.
/// </summary>
public static class MoveFromRunConverter
{
  public static DMW.MoveFromRun? CreateModelElement(DXW.MoveFromRun? openXmlElement)
  {
    return RunTrackChangeTypeConverter.CreateModelElement<DMW.MoveFromRun>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXW.MoveFromRun? openXmlElement, DMW.MoveFromRun? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return RunTrackChangeTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveFromRun model)
    where OpenXmlElementType: DXW.MoveFromRun, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.MoveFromRun openXmlElement, DMW.MoveFromRun model)
  {
    return RunTrackChangeTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
