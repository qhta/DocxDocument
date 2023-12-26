namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the Snapshot Class.
/// </summary>
public partial class Snapshot: ModelElement<DXO13WE.Snapshot>
{
  public Snapshot(): base(){ }
  
  public Snapshot(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Snapshot(DXO13WE.Snapshot openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [DataMember]
  public String? Embed
  {
    get => _Element?.Embed;
    set => _ExistingElement.Embed = value;
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get => _Element?.Link;
    set => _ExistingElement.Link = value;
  }
  
}
