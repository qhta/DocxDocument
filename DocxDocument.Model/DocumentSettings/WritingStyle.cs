namespace DocxDocument.Model;

public class WritingStyle: IWritingStyle
{
  /// <summary> 
  /// Application Name.
  ///</summary> 
  public string? ApplicationName { get; set; }
  /// <summary> 
  /// Check Stylistic Rules With Grammar.
  ///</summary> 
  public bool? CheckStyle { get; set; }
  /// <summary> 
  /// Grammatical Check Engine Version.
  ///</summary> 
  public int? DllVersion { get; set; }
  /// <summary> 
  /// Writing Style Language.
  ///</summary> 
  public string? Language { get; set; }
  /// <summary> 
  /// Natural Language Grammar Check.
  ///</summary> 
  public bool? NaturalLanguageGrammarCheck { get; set; }
  /// <summary> 
  /// Grammatical Engine ID.
  ///</summary> 
  public int? VendorID { get; set; }

}