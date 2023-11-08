namespace DocumentModel.Wordprocessing;


/// <summary>
///   Legacy Numbering Level Properties.
/// </summary>
public partial class LegacyNumbering: ModelElement<DXW.LegacyNumbering>
{
  public LegacyNumbering(): base(){ }
  
  public LegacyNumbering(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LegacyNumbering(DXW.LegacyNumbering openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  [DataMember]
  public Boolean? Legacy
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Legacy);
    }
    set
    {
      _ExistingElement.Legacy = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  [DataMember]
  public String? LegacySpace
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LegacySpace);
    }
    set
    {
      _ExistingElement.LegacySpace = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Legacy Indent
  /// </summary>
  [DataMember]
  public String? LegacyIndent
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LegacyIndent);
    }
    set
    {
      _ExistingElement.LegacyIndent = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
