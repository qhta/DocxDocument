namespace DocumentModel.Packaging;

/// <summary>
///   Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public class ReferenceRelationship: ModelElement
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public bool? IsExternal { get; set; }
  /// <summary>
  ///   Gets the relationship ID.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Gets the target URI of the relationship.
  /// </summary>
  public Uri? Uri { get; set; }
}