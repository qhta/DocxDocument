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
    get
    {
      return StringValueConverter.GetValue(_Element?.Embed);
    }
    set
    {
      _ExistingElement.Embed = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Link);
    }
    set
    {
      _ExistingElement.Link = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMD.BlipExtensionList? BlipExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.BlipExtensionList,DXD.BlipExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BlipExtensionList,DXD.BlipExtensionList>(value);
    }
  }
  
}
