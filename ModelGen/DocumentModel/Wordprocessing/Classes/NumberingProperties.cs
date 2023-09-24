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
  public Int32? NumberingId { get; set; }
  
  
  /// <summary>
  ///   Previous Paragraph Numbering Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get; set; }
  
  
  /// <summary>
  ///   Inserted Numbering Properties.
  /// </summary>
  public TrackChangeType? Inserted { get; set; }
  
}
