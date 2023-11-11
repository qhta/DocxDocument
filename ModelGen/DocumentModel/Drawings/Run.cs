namespace DocumentModel.Drawings;


/// <summary>
///   Text Run.
/// </summary>
public partial class Run: ModelElement<DXD.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXD.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Character Properties.
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
  
  
  /// <summary>
  ///   Text String.
  /// </summary>
  [DataMember]
  public DMD.Text? Text
  {
    get
    {
      return _Element?.GetObject<DMD.Text,DXD.Text>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Text,DXD.Text>(value);
    }
  }
  
}
