namespace DocumentModel.Drawings;


/// <summary>
///   Text Line Break.
/// </summary>
public partial class Break: ModelElement<DXD.Break>
{
  public Break(): base(){ }
  
  public Break(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Break(DXD.Break openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get
    {
      return _Element?.GetObject<DMD.RunProperties,DXD.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RunProperties,DXD.RunProperties>(value);
    }
  }
  
}
