namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a relative offset effect. Sets up a new origin by offsetting relative to the size of the previous effect.
/// </summary>
public partial class RelativeOffset: ModelElement<DXD.RelativeOffset>
{
  public RelativeOffset(): base(){ }
  
  public RelativeOffset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeOffset(DXD.RelativeOffset openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the X offset.
  /// </summary>
  [DataMember]
  public Int32? OffsetX
  {
    get => _Element?.OffsetX?.Value;
    set => _ExistingElement.OffsetX = value;
  }
  
  
  /// <summary>
  ///   Specifies the Y offset.
  /// </summary>
  [DataMember]
  public Int32? OffsetY
  {
    get => _Element?.OffsetY?.Value;
    set => _ExistingElement.OffsetY = value;
  }
  
}
