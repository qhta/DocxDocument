namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HeaderFooterReferenceType Class.
/// </summary>
public partial class HeaderFooterReferenceType: ModelElement<DXW.HeaderFooterReferenceType>
{
  public HeaderFooterReferenceType(): base(){ }
  
  public HeaderFooterReferenceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooterReferenceType(DXW.HeaderFooterReferenceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
