namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Binning Class.
/// </summary>
public partial class Binning: ModelElement<DXO16DCD.Binning>
{
  public Binning(): base(){ }
  
  public Binning(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Binning(DXO16DCD.Binning openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   underflow, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Underflow
  {
    get => _Element?.Underflow;
    set => _ExistingElement.Underflow = value;
  }
  
  
  /// <summary>
  ///   overflow, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Overflow
  {
    get => _Element?.Overflow;
    set => _ExistingElement.Overflow = value;
  }
  
  
  /// <summary>
  ///   Xsddouble.
  /// </summary>
  [DataMember]
  public DMDCD16.Xsddouble? Xsddouble
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   BinCountXsdunsignedInt.
  /// </summary>
  [DataMember]
  public DMDCD16.BinCountXsdunsignedInt? BinCountXsdunsignedInt
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
