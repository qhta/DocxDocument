namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RunConflictInsertion"/> class from/to OpenXml converter.
/// </summary>
public static class RunConflictInsertionConverter
{
  public static DMW.RunConflictInsertion? CreateModelElement(DXO10W.RunConflictInsertion? openXmlElement)
  {
    return RunTrackChangeTypeO10WConverter.CreateModelElement<DMW.RunConflictInsertion>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXO10W.RunConflictInsertion? openXmlElement, DMW.RunConflictInsertion? model, DiffList? diffs, string? objName)
  {
    return RunTrackChangeTypeO10WConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunConflictInsertion model)
    where OpenXmlElementType: DXO10W.RunConflictInsertion, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXO10W.RunConflictInsertion openXmlElement, DMW.RunConflictInsertion model)
  {
    return RunTrackChangeTypeO10WConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
