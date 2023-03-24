using DocumentModel;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CustomFilePropertiesPart
/// </summary>
public class CustomFilePropertiesPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public CustomProperties? Properties { get; set; }

  public String? RelationshipType { get; set; }
}