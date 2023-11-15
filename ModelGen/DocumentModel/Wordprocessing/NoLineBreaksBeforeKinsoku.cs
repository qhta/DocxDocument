namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public partial class NoLineBreaksBeforeKinsoku: ModelElement<DXW.NoLineBreaksBeforeKinsoku>
{
  public NoLineBreaksBeforeKinsoku(): base(){ }
  
  public NoLineBreaksBeforeKinsoku(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoLineBreaksBeforeKinsoku(DXW.NoLineBreaksBeforeKinsoku openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [DataMember]
  public String? Language
  {
    get => _Element?.Language;
    set => _ExistingElement.Language = value;
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
