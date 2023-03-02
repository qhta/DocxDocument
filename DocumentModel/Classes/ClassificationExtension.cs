namespace DocumentModel;

/// <summary>
///   Defines the ClassificationExtension Class.
/// </summary>
public record ClassificationExtension
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri { get; set; }
}