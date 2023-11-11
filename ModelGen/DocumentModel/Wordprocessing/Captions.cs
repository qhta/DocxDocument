namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions: ModelElement<DXW.Captions>
{
  public Captions(): base(){ }
  
  public Captions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Captions(DXW.Captions openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.AutoCaptions? AutoCaptions
  {
    get
    {
      return _Element?.GetObject<DMW.AutoCaptions,DXW.AutoCaptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AutoCaptions,DXW.AutoCaptions>(value);
    }
  }
  
}
