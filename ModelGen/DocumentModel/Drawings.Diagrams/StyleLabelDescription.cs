namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label Description.
/// </summary>
public partial class StyleLabelDescription: ModelElement<DXDDD.StyleLabelDescription>
{
  public StyleLabelDescription(): base(){ }
  
  public StyleLabelDescription(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLabelDescription(DXDDD.StyleLabelDescription openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Natural Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   Description Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
