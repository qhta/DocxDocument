namespace DocumentModel.Wordprocessing;

/// <summary>
///   Single Automatic Captioning Setting.
/// </summary>
public record AutoCaption
{
  /// <summary>
  ///   Identifier of Object to be Automatically Captioned
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Caption Used for Automatic Captioning
  /// </summary>
  public String? Caption { get; set; }
}