namespace DocumentModel.Drawings;


/// <summary>
///   Normal AutoFit.
/// </summary>
public partial class NormalAutoFit: ModelElement<DXD.NormalAutoFit>
{
  public NormalAutoFit(): base(){ }
  
  public NormalAutoFit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NormalAutoFit(DXD.NormalAutoFit openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Font Scale
  /// </summary>
  [DataMember]
  public Int32? FontScale
  {
    get => _Element?.FontScale?.Value;
    set => _ExistingElement.FontScale = value;
  }
  
  
  /// <summary>
  ///   Line Space Reduction
  /// </summary>
  [DataMember]
  public Int32? LineSpaceReduction
  {
    get => _Element?.LineSpaceReduction?.Value;
    set => _ExistingElement.LineSpaceReduction = value;
  }
  
}
