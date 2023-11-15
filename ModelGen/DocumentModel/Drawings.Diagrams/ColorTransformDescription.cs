namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Description.
/// </summary>
public partial class ColorTransformDescription: ModelElement<DXDDD.ColorTransformDescription>
{
  public ColorTransformDescription(): base(){ }
  
  public ColorTransformDescription(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformDescription(DXDDD.ColorTransformDescription openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
  }
  
  
  /// <summary>
  ///   Description Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
