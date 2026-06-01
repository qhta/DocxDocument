namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Represents the type of part referenced by a .
/// </summary>
public class DataPart: ModelElement
{
  /// <summary>
  ///   Gets the internal part path Iin the package.
  /// </summary>
  public Uri? Uri { get; set; }

  /// <summary>
  ///   Gets the content type (MIME type) of the data Iin the part.
  /// </summary>
  public string? ContentType { get; set; }
}
