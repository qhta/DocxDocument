namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies information about the parameters of the grammar checking 
///   which was performed on the contents of the current WordprocessingML document. 
/// </summary>
public interface IActiveWritingStyle: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Specifies the name of the application which specified the grammatical settings 
  ///   contained on the attributes for this element.
  /// </summary>
  public string? ApplicationName { get; set; }
  /// <summary>
  ///   Specifies if the grammar content checking performed on this document 
  ///   included stylistic rules for the document content. 
  ///   If specified, applications which support this functionality shall check stylistic rules 
  ///   as well as grammatical ones when checking the grammatical content of this document. 
  /// </summary>
  public bool? CheckStyle { get; set; }
  /// <summary>
  ///   Specifies the version of the engine that was used to check the grammatical content 
  ///   of the WordprocessingML document.
  /// </summary>
  public Int32? DllVersion { get; set; }
  /// <summary>
  ///   Specifies a value indicating a unique ID for the writing style engine 
  ///   that was used to check the grammatical content of the WordprocessingML document.
  /// </summary>
  public UInt16? VendorID { get; set; }
  /// <summary>
  ///   Specifies the language of the engine used to perform the grammatical content checking.
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Specifies whether the engine that was used to check the grammatical content 
  ///   of the WordprocessingML document performed natural language-based analysis.
  /// </summary>
  public bool? NaturalLanguageGrammarCheck { get; set; }

}