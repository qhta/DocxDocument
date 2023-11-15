namespace DocumentModel.Vml;


/// <summary>
///   Shape Clipping Path.
/// </summary>
public partial class ClipPath: ModelElement<DXVO.ClipPath>
{
  public ClipPath(): base(){ }
  
  public ClipPath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ClipPath(DXVO.ClipPath openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Path Definition
  /// </summary>
  [DataMember]
  public String? Value
  {
    get => _Element?.Value;
    set => _ExistingElement.Value = value;
  }
  
}
