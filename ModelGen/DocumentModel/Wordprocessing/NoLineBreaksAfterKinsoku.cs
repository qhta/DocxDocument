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
    get
    {
      return StringValueConverter.GetValue(_Element?.Language);
    }
    set
    {
      _ExistingElement.Language = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   val
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
