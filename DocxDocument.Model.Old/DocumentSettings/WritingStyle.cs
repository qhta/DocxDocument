namespace DocxDocument.Model;

public class WritingStyle: DocxBasedElement<WD.ActiveWritingStyle>, IWritingStyle
{
  public WritingStyle() : base(new WD.ActiveWritingStyle())
  {
  }

  public WritingStyle(WD.ActiveWritingStyle element) : base(element)
  {
  }

  /// <summary> 
  /// Application Name.
  ///</summary> 
  public string? ApplicationName
  {
    get => DocxElement.ApplicationName?.Value;
    set => DocxElement.ApplicationName = (value != null) ? (string)value : null;
  }

  /// <summary> 
  /// Check Stylistic Rules With Grammar.
  ///</summary> 
  public bool? CheckStyle
  {
    get => DocxElement.CheckStyle?.Value;
    set => DocxElement.CheckStyle = (value != null) ? (bool)value : null;
  }

  /// <summary> 
  /// Grammatical Check Engine Version.
  ///</summary> 
  public int? DllVersion
  {
    get => DocxElement.DllVersion?.Value;
    set => DocxElement.DllVersion = (value != null) ? (int)value : null;
  }

  /// <summary> 
  /// Writing Style Language.
  ///</summary> 
  public string? Language
  {
    get => DocxElement.Language?.Value;
    set => DocxElement.Language = (value != null) ? (string)value : null;
  }

  /// <summary> 
  /// Natural Language Grammar Check.
  ///</summary> 
  public bool? NaturalLanguageGrammarCheck
  {
    get => DocxElement.NaturalLanguageGrammarCheck?.Value;
    set => DocxElement.NaturalLanguageGrammarCheck = (value != null) ? (bool)value : null;
  }

  /// <summary> 
  /// Grammatical Engine ID.
  ///</summary> 
  public int? VendorID
  {
    get => DocxElement.VendorID?.Value;
    set => DocxElement.VendorID = (value != null) ? (UInt16)value : null;
  }

}