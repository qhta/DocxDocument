namespace DocumentModel.Wordprocessing;


/// <summary>
///   Grammar Checking Settings.
/// </summary>
public partial class ActiveWritingStyle
{
  
  /// <summary>
  ///   Writing Style Language
  /// </summary>
  [SchemaAttr("w:lang")]
  public String? Language { get; set; }
  
  
  /// <summary>
  ///   Grammatical Engine ID
  /// </summary>
  [SchemaAttr("w:vendorID")]
  public UInt16? VendorID { get; set; }
  
  
  /// <summary>
  ///   Grammatical Check Engine Version
  /// </summary>
  [SchemaAttr("w:dllVersion")]
  public Int32? DllVersion { get; set; }
  
  
  /// <summary>
  ///   Natural Language Grammar Check
  /// </summary>
  [SchemaAttr("w:nlCheck")]
  public Boolean? NaturalLanguageGrammarCheck { get; set; }
  
  
  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  [SchemaAttr("w:checkStyle")]
  public Boolean? CheckStyle { get; set; }
  
  
  /// <summary>
  ///   Application Name
  /// </summary>
  [SchemaAttr("w:appName")]
  public String? ApplicationName { get; set; }
  
}
