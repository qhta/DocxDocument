namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom Set of Characters Which Cannot End a Line.
/// </summary>
public partial class NoLineBreaksAfterKinsoku: ModelElement<DXW.NoLineBreaksAfterKinsoku>
{
  public NoLineBreaksAfterKinsoku(): base(){ }
  
  public NoLineBreaksAfterKinsoku(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoLineBreaksAfterKinsoku(DXW.NoLineBreaksAfterKinsoku openXmlElement): base(openXmlElement) { }
  
  
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
