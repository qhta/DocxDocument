namespace DocumentModel.Wordprocessing;


/// <summary>
///   Associated Help Text.
/// </summary>
public partial class HelpText: ModelElement<DXW.HelpText>
{
  public HelpText(): base(){ }
  
  public HelpText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HelpText(DXW.HelpText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Help Text Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
