namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.DeletedRun"/> class from/to OpenXml converter.
/// </summary>
public static class DeletedRunConverter
{
  public static DMW.DeletedRun? CreateModelElement(DXW.DeletedRun? openXmlElement)
  {
    return RunTrackChangeTypeConverter.CreateModelElement<DMW.DeletedRun>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXW.DeletedRun? openXmlElement, DMW.DeletedRun? model, DiffList? diffs, string? objName)
  {
    return RunTrackChangeTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DeletedRun model)
    where OpenXmlElementType: DXW.DeletedRun, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.DeletedRun openXmlElement, DMW.DeletedRun model)
  {
    return RunTrackChangeTypeConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
