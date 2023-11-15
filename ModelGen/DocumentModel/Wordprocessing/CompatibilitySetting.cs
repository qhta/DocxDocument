namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatibilitySetting Class.
/// </summary>
public partial class CompatibilitySetting: ModelElement<DXW.CompatibilitySetting>
{
  public CompatibilitySetting(): base(){ }
  
  public CompatibilitySetting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   uri
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
