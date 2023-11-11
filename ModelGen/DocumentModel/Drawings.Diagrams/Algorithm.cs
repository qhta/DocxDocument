namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Algorithm.
/// </summary>
public partial class Algorithm: ModelElement<DXDDD.Algorithm>
{
  public Algorithm(): base(){ }
  
  public Algorithm(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Algorithm(DXDDD.Algorithm openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Number
  /// </summary>
  [DataMember]
  public UInt32? Revision
  {
    get
    {
      return _Element?.Revision?.Value;
    }
    set
    {
      _ExistingElement.Revision = value;
    }
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.ExtensionList,DXDDD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ExtensionList,DXDDD.ExtensionList>(value);
    }
  }
  
}
