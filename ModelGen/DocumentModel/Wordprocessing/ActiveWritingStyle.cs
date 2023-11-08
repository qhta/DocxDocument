namespace DocumentModel.Wordprocessing;


/// <summary>
///   Grammar Checking Settings.
/// </summary>
public partial class ActiveWritingStyle: ModelElement<DXW.ActiveWritingStyle>
{
  public ActiveWritingStyle(): base(){ }
  
  public ActiveWritingStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ActiveWritingStyle(DXW.ActiveWritingStyle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Writing Style Language
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
  ///   Grammatical Engine ID
  /// </summary>
  [DataMember]
  public UInt16? VendorID
  {
    get
    {
      return _Element?.VendorID?.Value;
    }
    set
    {
      _ExistingElement.VendorID = value;
    }
  }
  
  
  /// <summary>
  ///   Grammatical Check Engine Version
  /// </summary>
  [DataMember]
  public Int32? DllVersion
  {
    get
    {
      return _Element?.DllVersion?.Value;
    }
    set
    {
      _ExistingElement.DllVersion = value;
    }
  }
  
  
  /// <summary>
  ///   Natural Language Grammar Check
  /// </summary>
  [DataMember]
  public Boolean? NaturalLanguageGrammarCheck
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NaturalLanguageGrammarCheck);
    }
    set
    {
      _ExistingElement.NaturalLanguageGrammarCheck = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  [DataMember]
  public Boolean? CheckStyle
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.CheckStyle);
    }
    set
    {
      _ExistingElement.CheckStyle = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Application Name
  /// </summary>
  [DataMember]
  public String? ApplicationName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ApplicationName);
    }
    set
    {
      _ExistingElement.ApplicationName = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
