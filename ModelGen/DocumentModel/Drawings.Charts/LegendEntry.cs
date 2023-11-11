namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend Entry.
/// </summary>
public partial class LegendEntry: ModelElement<DXDC.LegendEntry>
{
  public LegendEntry(): base(){ }
  
  public LegendEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegendEntry(DXDC.LegendEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      return _Element?.GetObject<DMDC.Index,DXDC.Index>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Index,DXDC.Index>(value);
    }
  }
  
  [DataMember]
  public DMDC.Delete? Delete
  {
    get
    {
      return _Element?.GetObject<DMDC.Delete,DXDC.Delete>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Delete,DXDC.Delete>(value);
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
