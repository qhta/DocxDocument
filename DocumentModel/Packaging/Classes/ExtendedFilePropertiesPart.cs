using DocumentModel;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExtendedFilePropertiesPart
/// </summary>
public class ExtendedFilePropertiesPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ContentProperties? Properties { get; set; }

  public String? RelationshipType { get; set; }
}