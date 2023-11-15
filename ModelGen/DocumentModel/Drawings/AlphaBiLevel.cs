namespace DocumentModel.Drawings;


/// <summary>
///   This element represents an Alpha Bi-Level Effect.
/// </summary>
public partial class AlphaBiLevel: ModelElement<DXD.AlphaBiLevel>
{
  public AlphaBiLevel(): base(){ }
  
  public AlphaBiLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaBiLevel(DXD.AlphaBiLevel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the threshold value for the alpha bi-level effect.
  /// </summary>
  [DataMember]
  public Int32? Threshold
  {
    get => _Element?.Threshold?.Value;
    set => _ExistingElement.Threshold = value;
  }
  
}
