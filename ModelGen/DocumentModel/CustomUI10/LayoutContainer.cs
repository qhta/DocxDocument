namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public partial class LayoutContainer: ModelElement<DXO10CUI.LayoutContainer>
{
  public LayoutContainer(): base(){ }
  
  public LayoutContainer(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutContainer(DXO10CUI.LayoutContainer openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get => _Element?.QualifiedId;
    set => _ExistingElement.QualifiedId = value;
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
}
