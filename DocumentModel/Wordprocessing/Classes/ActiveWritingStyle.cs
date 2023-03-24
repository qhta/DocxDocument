namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Grammar Checking Settings.
/// </summary>
public class ActiveWritingStyle: ModelElement
{
  /// <summary>
  ///   Writing Style Language
  /// </summary>
  public String? Language { get; set; }

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
  public Boolean? NaturalLanguageGrammarCheck { get; set; }

  /// <summary>
  ///   Check Stylistic Rules With Grammar
  /// </summary>
  public Boolean? CheckStyle { get; set; }

  /// <summary>
  ///   Application Name
  /// </summary>
  public String? ApplicationName { get; set; }
}