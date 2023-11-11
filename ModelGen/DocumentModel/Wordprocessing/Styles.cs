namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies all of the style information stored in the WordprocessingML document: style definitions as well as latent style information.
/// </summary>
public partial class Styles: ModelElement<DXW.Styles>
{
  public Styles(): base(){ }
  
  public Styles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Styles(DXW.Styles openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  [DataMember]
  public DMW.DocDefaults? DocDefaults
  {
    get
    {
      return _Element?.GetObject<DMW.DocDefaults,DXW.DocDefaults>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocDefaults,DXW.DocDefaults>(value);
    }
  }
  
  
  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  [DataMember]
  public DMW.LatentStyles? LatentStyles
  {
    get
    {
      return _Element?.GetObject<DMW.LatentStyles,DXW.LatentStyles>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LatentStyles,DXW.LatentStyles>(value);
    }
  }
  
}
