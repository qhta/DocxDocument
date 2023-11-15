namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Title.
/// </summary>
public partial class Title: ModelElement<DXDDD.Title>
{
  public Title(): base(){ }
  
  public Title(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Title(DXDDD.Title openXmlElement): base(openXmlElement) { }
  
  
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
