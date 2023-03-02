namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public record SdtContentText
{
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine { get; set; }
}