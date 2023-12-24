namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public partial class DocGrid: ModelElement<DXW.DocGrid>
{
  public DocGrid(): base(){ }
  
  public DocGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocGrid(DXW.DocGrid openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Grid Line Pitch
  /// </summary>
  [DataMember]
  public Int32? LinePitch
  {
    get => _Element?.LinePitch?.Value;
    set => _ExistingElement.LinePitch = value;
  }
  
  
  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  [DataMember]
  public Int32? CharacterSpace
  {
    get => _Element?.CharacterSpace?.Value;
    set => _ExistingElement.CharacterSpace = value;
  }
  
}
