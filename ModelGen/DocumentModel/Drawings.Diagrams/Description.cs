namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Description.
/// </summary>
public partial class Description: ModelElement<DXDDD.Description>
{
  public Description(): base(){ }
  
  public Description(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Description(DXDDD.Description openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
