namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the parent structured document tag is a checkbox when displayed in the document. The parent structured document tag contents MUST contain a single character and optionally an additional character in a deleted run.
/// </summary>
public partial class SdtContentCheckBox
{
  
  /// <summary>
  ///   Checked.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffValues? Checked { get; set; }
  
  
  /// <summary>
  ///   CheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? CheckedState { get; set; }
  
  
  /// <summary>
  ///   UncheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? UncheckedState { get; set; }
  
}
