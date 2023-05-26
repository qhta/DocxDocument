namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SuperArgument"/> class from/to OpenXml converter.
/// </summary>
public static class SuperArgumentConverter
{

  #region SuperArgument model conversion.
  public static DMM.SuperArgument? CreateModelElement(DXM.SuperArgument? openXmlElement)
  {
    return ArgumentConverter.CreateModelElement<DMM.SuperArgument>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXM.SuperArgument? openXmlElement, DMM.SuperArgument? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ArgumentConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.SuperArgument model)
    where OpenXmlElementType: DXM.SuperArgument, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.SuperArgument openXmlElement, DMM.SuperArgument model)
  {
    return ArgumentConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
