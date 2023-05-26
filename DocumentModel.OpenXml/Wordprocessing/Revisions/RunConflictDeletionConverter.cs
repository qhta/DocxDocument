namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RunConflictDeletion"/> class from/to OpenXml converter.
/// </summary>
public static class RunConflictDeletionConverter
{
  public static DMW.RunConflictDeletion? CreateModelElement(DXO10W.RunConflictDeletion? openXmlElement)
  {
    return RunTrackChangeTypeO10WConverter.CreateModelElement<DMW.RunConflictDeletion>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXO10W.RunConflictDeletion? openXmlElement, DMW.RunConflictDeletion? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return RunTrackChangeTypeO10WConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunConflictDeletion model)
    where OpenXmlElementType: DXO10W.RunConflictDeletion, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXO10W.RunConflictDeletion openXmlElement, DMW.RunConflictDeletion model)
  {
    return RunTrackChangeTypeO10WConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
}
