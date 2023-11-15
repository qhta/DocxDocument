namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Parameter.
/// </summary>
public partial class Parameter: ModelElement<DXDDD.Parameter>
{
  public Parameter(): base(){ }
  
  public Parameter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Parameter(DXDDD.Parameter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
