namespace DocumentModel.Drawings;


/// <summary>
///   Defines the PredecessorDrawingElementReference Class.
/// </summary>
public partial class PredecessorDrawingElementReference: ModelElement<DXO16D.PredecessorDrawingElementReference>
{
  public PredecessorDrawingElementReference(): base(){ }
  
  public PredecessorDrawingElementReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PredecessorDrawingElementReference(DXO16D.PredecessorDrawingElementReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   pred, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Pred
  {
    get => _Element?.Pred;
    set => _ExistingElement.Pred = value;
  }
  
}
