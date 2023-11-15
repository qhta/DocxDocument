namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the effect that can be applied to a table as a whole through a table style.
/// </summary>
public partial class Effect: ModelElement<DXD.Effect>
{
  public Effect(): base(){ }
  
  public Effect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Effect(DXD.Effect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference
  /// </summary>
  [DataMember]
  public String? Reference
  {
    get => _Element?.Reference;
    set => _ExistingElement.Reference = value;
  }
  
}
