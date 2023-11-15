namespace DocumentModel.Word13;


/// <summary>
///   This element specifies that the parent structured document tag is a container for repeated items.
/// </summary>
public partial class SdtRepeatedSection: ModelElement<DXO13W.SdtRepeatedSection>
{
  public SdtRepeatedSection(): base(){ }
  
  public SdtRepeatedSection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtRepeatedSection(DXO13W.SdtRepeatedSection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SectionTitle.
  /// </summary>
  [DataMember]
  public String? SectionTitle
  {
    get => _Element?.GetStringVal<DXO13W.SectionTitle>();
    set => _ExistingElement.SetStringVal<DXO13W.SectionTitle>(value);
  }
  
  
  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  [DataMember]
  public DMW13.DoNotAllowInsertDeleteSection? DoNotAllowInsertDeleteSection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Word.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Word.OnOffType");
  }
  
}
