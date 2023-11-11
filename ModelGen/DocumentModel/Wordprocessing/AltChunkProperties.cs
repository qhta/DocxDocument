namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Content Import Properties.
/// </summary>
public partial class AltChunkProperties: ModelElement<DXW.AltChunkProperties>
{
  public AltChunkProperties(): base(){ }
  
  public AltChunkProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AltChunkProperties(DXW.AltChunkProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  [DataMember]
  public DMW.MatchSource? MatchSource
  {
    get
    {
      return _Element?.GetObject<DMW.MatchSource,DXW.MatchSource>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MatchSource,DXW.MatchSource>(value);
    }
  }
  
}
