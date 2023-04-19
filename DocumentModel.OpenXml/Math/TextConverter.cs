namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Text"/> class from/to OpenXml converter.
/// </summary>
public static class TextConverter
{
  //#region space conversion.
  //private static DM.SpaceProcessingMode? GetSpace(DXM.Text openXmlElement)
  //{
  //  return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  //}
  
  //private static bool CmpSpace(DXM.Text openXmlElement, DM.SpaceProcessingMode? value, DiffList? diffs, string? objName)
  //{
  //  return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value, value, diffs, objName);
  //}
  
  //private static void SetSpace(DXM.Text openXmlElement, DM.SpaceProcessingMode? value)
  //{
  //  openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(value);
  //}
  //#endregion

  #region Text model conversion.
  public static DMM.Text? CreateModelElement(DXM.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      return DMXW.TextTypeConverter.CreateModelElement(openXmlElement);
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Text? openXmlElement, DMM.Text? model, DiffList? diffs, string? objName)
  {
    return DMXW.TextTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static DXM.Text CreateOpenXmlElement(DMM.Text model)
  {
    return DMXW.TextTypeConverter.CreateOpenXmlElement(model);
  }
  
  //public static void UpdateOpenXmlElement(DXM.Text openXmlElement, DMM.Text model)
  //{
  //  SetSpace(openXmlElement, model?.Space);
  //}
  #endregion
}
