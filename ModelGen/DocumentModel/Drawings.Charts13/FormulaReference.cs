namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FormulaReference Class.
/// </summary>
public partial class FormulaReference: ModelElement<DXO13DC.FormulaReference>
{
  public FormulaReference(): base(){ }
  
  public FormulaReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormulaReference(DXO13DC.FormulaReference openXmlElement): base(openXmlElement) { }
  
  
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
