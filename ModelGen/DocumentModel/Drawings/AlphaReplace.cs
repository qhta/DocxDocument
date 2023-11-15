namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an alpha replace effect.
/// </summary>
public partial class AlphaReplace: ModelElement<DXD.AlphaReplace>
{
  public AlphaReplace(): base(){ }
  
  public AlphaReplace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlphaReplace(DXD.AlphaReplace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the new opacity value.
  /// </summary>
  [DataMember]
  public Int32? Alpha
  {
    get => _Element?.Alpha?.Value;
    set => _ExistingElement.Alpha = value;
  }
  
}
