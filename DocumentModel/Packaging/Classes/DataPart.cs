namespace DocumentModel.Packaging;

/// <summary>
///   Represents the type of part referenced by a .
/// </summary>
public record DataPart
{
  /// <summary>
  ///   Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri { get; set; }

  /// <summary>
  ///   Gets the content type (MIME type) of the data in the part.
  /// </summary>
  public String? ContentType { get; set; }
}