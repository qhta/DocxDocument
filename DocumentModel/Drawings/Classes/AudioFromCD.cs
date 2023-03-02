namespace DocumentModel.Drawings;

/// <summary>
///   Audio from CD.
/// </summary>
public record AudioFromCD
{
  /// <summary>
  ///   Audio Start Time.
  /// </summary>
  public AudioCDTimeType? StartTime { get; set; }

  /// <summary>
  ///   Audio End Time.
  /// </summary>
  public AudioCDTimeType? EndTime { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}