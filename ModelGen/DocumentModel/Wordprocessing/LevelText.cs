namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Text.
/// </summary>
public partial class LevelText: ModelElement<DXW.LevelText>
{
  public LevelText(): base(){ }
  
  public LevelText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelText(DXW.LevelText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Level Text
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
  
  
  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  [DataMember]
  public Boolean? Null
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Null);
    }
    set
    {
      _ExistingElement.Null = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
