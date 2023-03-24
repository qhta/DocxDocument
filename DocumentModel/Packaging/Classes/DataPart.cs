namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents the type of part referenced by a .
/// </summary>
public class DataPart: ModelElement
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