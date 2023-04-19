namespace DocumentModel.Wordprocessing;

/// <summary>
///   Grammar Checking Settings.
/// </summary>
public class ActiveWritingStyle: ModelElement
{
  /// <summary>
  ///   Writing Style Language
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Grammatical Engine ID
  /// </summary>
  public UInt16? VendorID { get; set; }

  /// <summary>
  ///   Grammatical Check Engine Version
  /// </summary>
  public Int32? DllVersion { get; set; }

  /// <summary>
  ///   Natural Language Grammar Check
  /// </summary>
  public bool? NaturalLanguageGrammarCheck { get; set; }

  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  public bool? CheckStyle { get; set; }

  /// <summary>
  ///   Application Name
  /// </summary>
  public string? ApplicationName { get; set; }
}