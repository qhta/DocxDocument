using DocumentModel;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CustomFilePropertiesPart
/// </summary>
public class CustomFilePropertiesPart: ModelElement
{
  public string? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomProperties? Properties { get; set; }

  public string? RelationshipType { get; set; }
}