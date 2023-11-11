namespace DocumentModel.Wordprocessing;


/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids: ModelElement<DXW.Rsids>
{
  public Rsids(): base(){ }
  
  public Rsids(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rsids(DXW.Rsids openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  [DataMember]
  public DMW.RsidRoot? RsidRoot
  {
    get
    {
      return _Element?.GetObject<DMW.RsidRoot,DXW.RsidRoot>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RsidRoot,DXW.RsidRoot>(value);
    }
  }
  
}
