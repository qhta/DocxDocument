namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grammar Checking Settings.
/// </summary>
public interface IActiveWritingStyle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Writing Style Language
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// Grammatical Engine ID
  /// </summary>
  public System.UInt16? VendorID { get ; set; }
  
  /// <summary>
  /// Grammatical Check Engine Version
  /// </summary>
  public System.Int32? DllVersion { get ; set; }
  
  /// <summary>
  /// Natural Language Grammar Check
  /// </summary>
  public System.Boolean? NaturalLanguageGrammarCheck { get ; set; }
  
  /// <summary>
  /// Check Stylistic Rules With Grammar
  /// </summary>
  public System.Boolean? CheckStyle { get ; set; }
  
  /// <summary>
  /// Application Name
  /// </summary>
  public System.String? ApplicationName { get ; set; }
  
}
