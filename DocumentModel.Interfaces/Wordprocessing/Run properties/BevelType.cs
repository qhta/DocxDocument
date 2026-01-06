namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the BevelType Class.
/// </summary>
public interface BevelType
{
  /// <summary>
  ///   w
  /// </summary>
  public Int64? Width { get; set; }
  /// <summary>
  ///   h
  /// </summary>
  public Int64? Height { get; set; }
  /// <summary>
  ///   prst
  /// </summary>
  public BevelPresetKind? PresetProfileType { get; set; }
}