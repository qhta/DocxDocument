namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtPlaceholder Class.
/// </summary>
public interface SdtPlaceholder:
{
  /// <summary>
  ///   Document Part Reference.
  /// </summary>
  public string? DocPartReference { get; set; }
}