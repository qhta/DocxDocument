namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the inter-line and inter-paragraph spacing which shall be applied to the contents of this paragraph when it is displayed by a consumer.
/// </summary>
public partial class SpacingBetweenLines: ModelElement<DXW.SpacingBetweenLines>
{
  public SpacingBetweenLines(): base(){ }
  
  public SpacingBetweenLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpacingBetweenLines(DXW.SpacingBetweenLines openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Spacing Above Paragraph
  /// </summary>
  [DataMember]
  public String? Before
  {
    get => _Element?.Before;
    set => _ExistingElement.Before = value;
  }
  
  
  /// <summary>
  ///   Spacing Above Paragraph IN Line Units
  /// </summary>
  [DataMember]
  public Int32? BeforeLines
  {
    get => _Element?.BeforeLines?.Value;
    set => _ExistingElement.BeforeLines = value;
  }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Above Paragraph
  /// </summary>
  [DataMember]
  public Boolean? BeforeAutoSpacing
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Spacing Below Paragraph
  /// </summary>
  [DataMember]
  public String? After
  {
    get => _Element?.After;
    set => _ExistingElement.After = value;
  }
  
  
  /// <summary>
  ///   Spacing Below Paragraph in Line Units
  /// </summary>
  [DataMember]
  public Int32? AfterLines
  {
    get => _Element?.AfterLines?.Value;
    set => _ExistingElement.AfterLines = value;
  }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Below Paragraph
  /// </summary>
  [DataMember]
  public Boolean? AfterAutoSpacing
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Spacing Between Lines in Paragraph
  /// </summary>
  [DataMember]
  public String? Line
  {
    get => _Element?.Line;
    set => _ExistingElement.Line = value;
  }
  
}
