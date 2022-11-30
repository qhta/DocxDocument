namespace DocumentModel.Packaging;

/// <summary>
/// Defines a reference relationship. A reference relationship can be public or external.
/// </summary>
public interface IReferenceRelationship // : 
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  public System.Boolean? IsExternal { get ; set; }
  
  /// <summary>
  /// Gets the relationship ID.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Gets the target URI of the relationship.
  /// </summary>
  public System.Uri? Uri { get ; set; }
  
}
