namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Extension Class.
/// </summary>
public record Extension
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri { get; set; }
}