namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies a unique instance of numbering information that can be referenced by zero or more paragraphs 
///   within the parent WordprocessingML document.
/// </summary>
public class NumberingInstance: ModelElement
{
  /// <summary>
  ///   A value of 0 for NumberId shall never be used to point to a numbering definition instance,
  ///   and shall instead only be used to designate the removal of numbering properties 
  ///   at a particular level in the style hierarchy (typically via direct formatting). 
  /// </summary>
  public Int32? NumberID { get; set; }

  /// <summary>
  ///   Associates a unique hexadecimal ID to the numbering definition instance.
  /// </summary>
  public HexInt? DurableId { get; set; }

  /// <summary>
  ///   Specifies the abstract numbering definition information 
  ///   whose properties shall be inherited by the parent numbering definition instance.
  /// </summary>
  public Int32? AbstractNumId { get; set; }

  /// <summary>
  ///  Collection of NumLevelOverride elements
  /// </summary>
  public NumLevelOverrides? LevelOverrides { get; set; }
}