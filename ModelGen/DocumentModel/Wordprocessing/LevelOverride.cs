namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public partial class LevelOverride: ModelElement<DXW.LevelOverride>
{
  public LevelOverride(): base(){ }
  
  public LevelOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelOverride(DXW.LevelOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  [DataMember]
  public Int32? LevelIndex
  {
    get
    {
      return _Element?.LevelIndex?.Value;
    }
    set
    {
      _ExistingElement.LevelIndex = value;
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  [DataMember]
  public DMW.StartOverrideNumberingValue? StartOverrideNumberingValue
  {
    get
    {
      return _Element?.GetObject<DMW.StartOverrideNumberingValue,DXW.StartOverrideNumberingValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StartOverrideNumberingValue,DXW.StartOverrideNumberingValue>(value);
    }
  }
  
  
  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  [DataMember]
  public DMW.Level? Level
  {
    get
    {
      return _Element?.GetObject<DMW.Level,DXW.Level>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Level,DXW.Level>(value);
    }
  }
  
}
