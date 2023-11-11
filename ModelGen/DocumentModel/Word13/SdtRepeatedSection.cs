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
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXO13W.SectionTitle>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXO13W.SectionTitle>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  [DataMember]
  public DMW13.DoNotAllowInsertDeleteSection? DoNotAllowInsertDeleteSection
  {
    get
    {
      return _Element?.GetObject<DMW13.DoNotAllowInsertDeleteSection,DXO13W.DoNotAllowInsertDeleteSection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW13.DoNotAllowInsertDeleteSection,DXO13W.DoNotAllowInsertDeleteSection>(value);
    }
  }
  
}
