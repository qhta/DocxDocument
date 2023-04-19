namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SubArgument"/> class from/to OpenXml converter.
/// </summary>
public static class SubArgumentConverter
{

  #region SubArgument model conversion.
  public static DMM.SubArgument? CreateModelElement(DXM.SubArgument? openXmlElement)
  {
    return ArgumentConverter.CreateModelElement<DMM.SubArgument>(openXmlElement);
  }
  
  public static bool CompareModelElement(DXM.SubArgument? openXmlElement, DMM.SubArgument? model, DiffList? diffs, string? objName)
  {
    return ArgumentConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.SubArgument model)
    where OpenXmlElementType: DXM.SubArgument, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.SubArgument openXmlElement, DMM.SubArgument model)
  {
    return ArgumentConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
