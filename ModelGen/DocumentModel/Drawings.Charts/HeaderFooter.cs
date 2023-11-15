namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Header and Footer.
/// </summary>
public partial class HeaderFooter: ModelElement<DXDC.HeaderFooter>
{
  public HeaderFooter(): base(){ }
  
  public HeaderFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooter(DXDC.HeaderFooter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Align With Margins
  /// </summary>
  [DataMember]
  public Boolean? AlignWithMargins
  {
    get => _Element?.AlignWithMargins?.Value;
    set => _ExistingElement.AlignWithMargins = value;
  }
  
  
  /// <summary>
  ///   Different Odd Even
  /// </summary>
  [DataMember]
  public Boolean? DifferentOddEven
  {
    get => _Element?.DifferentOddEven?.Value;
    set => _ExistingElement.DifferentOddEven = value;
  }
  
  
  /// <summary>
  ///   Different First
  /// </summary>
  [DataMember]
  public Boolean? DifferentFirst
  {
    get => _Element?.DifferentFirst?.Value;
    set => _ExistingElement.DifferentFirst = value;
  }
  
  
  /// <summary>
  ///   Odd Header.
  /// </summary>
  [DataMember]
  public DMDC.OddHeader? OddHeader
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Odd Footer.
  /// </summary>
  [DataMember]
  public DMDC.OddFooter? OddFooter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Even Header.
  /// </summary>
  [DataMember]
  public DMDC.EvenHeader? EvenHeader
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Even Footer.
  /// </summary>
  [DataMember]
  public DMDC.EvenFooter? EvenFooter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   First Header.
  /// </summary>
  [DataMember]
  public DMDC.FirstHeader? FirstHeader
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   First Footer.
  /// </summary>
  [DataMember]
  public DMDC.FirstFooter? FirstFooter
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
