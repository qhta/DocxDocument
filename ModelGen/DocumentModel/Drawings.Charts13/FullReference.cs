namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FullReference Class.
/// </summary>
public partial class FullReference: ModelElement<DXO13DC.FullReference>
{
  public FullReference(): base(){ }
  
  public FullReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FullReference(DXO13DC.FullReference openXmlElement): base(openXmlElement) { }
  
  
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
