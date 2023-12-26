namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings: ModelElement<DXO16DCD.PrintSettings>
{
  public PrintSettings(): base(){ }
  
  public PrintSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintSettings(DXO16DCD.PrintSettings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   HeaderFooter.
  /// </summary>
  [DataMember]
  public DMDCD16.HeaderFooter? HeaderFooter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   PageMargins.
  /// </summary>
  [DataMember]
  public DMDCD16.PageMargins? PageMargins
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   PageSetup.
  /// </summary>
  [DataMember]
  public DMDCD16.PageSetup? PageSetup
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
  }
  
}
