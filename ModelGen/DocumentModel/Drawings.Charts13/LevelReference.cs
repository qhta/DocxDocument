namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the LevelReference Class.
/// </summary>
public partial class LevelReference: ModelElement<DXO13DC.LevelReference>
{
  public LevelReference(): base(){ }
  
  public LevelReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelReference(DXO13DC.LevelReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  [DataMember]
  public DMDC13.SequenceOfReferences? SequenceOfReferences
  {
    get
    {
      return _Element?.GetObject<DMDC13.SequenceOfReferences,DXO13DC.SequenceOfReferences>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.SequenceOfReferences,DXO13DC.SequenceOfReferences>(value);
    }
  }
  
}
