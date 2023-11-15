namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Automatic Captioning Setting.
/// </summary>
public partial class AutoCaption: ModelElement<DXW.AutoCaption>
{
  public AutoCaption(): base(){ }
  
  public AutoCaption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoCaption(DXW.AutoCaption openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Identifier of Object to be Automatically Captioned
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Caption Used for Automatic Captioning
  /// </summary>
  [DataMember]
  public String? Caption
  {
    get => _Element?.Caption;
    set => _ExistingElement.Caption = value;
  }
  
}
