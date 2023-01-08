namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public static class NumberDiagramInfoConverter
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public static UInt32? GetLvl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLvl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public static DocumentModel.Drawings.Diagram1.STorageType? GetPtType(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DocumentModel.Drawings.Diagram1.STorageType>(openXmlElement?.PtType?.Value);
  }
  
  public static void SetPtType(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, DocumentModel.Drawings.Diagram1.STorageType? value)
  {
    if (openXmlElement != null)
      openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DocumentModel.Drawings.Diagram1.STorageType>(value);
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public static DocumentModel.Drawings.Diagram1.DiagramAutoBullet? GetDiagramAutoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDiagramAutoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, DocumentModel.Drawings.Diagram1.DiagramAutoBullet? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
