namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumberingProperties Class.
/// </summary>
public class NumberingProperties: ModelElement
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