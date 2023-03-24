namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public class ReferenceRelationship: ModelElement
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public Boolean? IsExternal { get; set; }

  /// <summary>
  ///   Gets the relationship ID.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Gets the target URI of the relationship.
  /// </summary>
  public Uri? Uri { get; set; }
}