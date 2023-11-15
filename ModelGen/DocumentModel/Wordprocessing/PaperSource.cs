namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PaperSource Class.
/// </summary>
public partial class PaperSource: ModelElement<DXW.PaperSource>
{
  public PaperSource(): base(){ }
  
  public PaperSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PaperSource(DXW.PaperSource openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   First Page Printer Tray Code
  /// </summary>
  [DataMember]
  public UInt16? First
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
  }
  
  
  /// <summary>
  ///   Non-First Page Printer Tray Code
  /// </summary>
  [DataMember]
  public UInt16? Other
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt16]");
  }
  
}
