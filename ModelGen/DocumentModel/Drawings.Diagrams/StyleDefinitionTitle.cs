namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Title.
/// </summary>
public partial class StyleDefinitionTitle: ModelElement<DXDDD.StyleDefinitionTitle>
{
  public StyleDefinitionTitle(): base(){ }
  
  public StyleDefinitionTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDefinitionTitle(DXDDD.StyleDefinitionTitle openXmlElement): base(openXmlElement) { }
  
  
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
