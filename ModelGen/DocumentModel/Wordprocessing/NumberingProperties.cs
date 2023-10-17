namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the current paragraph uses numbering information that is defined by a particular numbering definition instance.
/// </summary>
public partial class NumberingProperties
{
  
  /// <summary>
  ///   Numbering Level Reference.
  /// </summary>
  public Int32? NumberingLevelReference { get; set; }
  
  
  /// <summary>
  ///   Numbering Definition Instance Reference.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingId? NumberingId { get; set; }
  
  
  /// <summary>
  ///   Previous Paragraph Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange { get; set; }
  
  
  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.Inserted? Inserted { get; set; }
  
}
