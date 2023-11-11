namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies information about the parameters of the grammar checking which was performed on the contents of the current WordprocessingML document. [Note: This information can be used as desired by applications; for example, to determine if the current grammar checking state, specified by the proofState element (§17.15.1.65) is sufficient. end note]
/// </summary>
[DataContract]
public partial class ActiveWritingStyle : ModelElement<DXW.ActiveWritingStyle>
{
  public ActiveWritingStyle(): base(){ }

  public ActiveWritingStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ActiveWritingStyle(DXW.ActiveWritingStyle openXmlElement): base(openXmlElement) { }

  /// <summary>
  /// Writing Style Language
  /// </summary>
  [DataMember]
  public string? Language
  {
    get => _Element?.Language?.Value;
    set => _ExistingElement.Language = value;
  }

  /// <summary>
  /// Grammatical Engine ID
  /// </summary>
  [DataMember]
  public ushort? VendorID
  {
    get => _Element?.VendorID?.Value;
    set => _ExistingElement.VendorID = value;
  }

  /// <summary>
  /// Grammatical Check Engine Version
  /// </summary>
  [DataMember]
  public int? DllVersion
  {
    get => _Element?.DllVersion?.Value;
    set => _ExistingElement.DllVersion = value;
  }

  /// <summary>
  /// Natural Language Grammar Check
  /// </summary>
  [DataMember]
  public bool? NaturalLanguageGrammarCheck
  {
    get => _Element?.NaturalLanguageGrammarCheck?.Value;
    set => _ExistingElement.NaturalLanguageGrammarCheck = value;
  }

  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  [DataMember]
  public bool? CheckStyle
  {
    get => _Element?.CheckStyle?.Value;
    set => _ExistingElement.CheckStyle = value;
  }

  /// <summary>
  /// Application Name
  /// </summary>
  [DataMember]
  public string? ApplicationName
  {
    get => _Element?.ApplicationName?.Value;
    set => _ExistingElement.ApplicationName = value;
  }

}
