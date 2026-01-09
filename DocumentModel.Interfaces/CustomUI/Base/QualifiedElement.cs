namespace DocumentModel;

/// <summary>
///   Defines the common properties for all custom UI controls.
///   Reuses the IdentifiedElement interface for the Id property and adds QualifiedId and insertion attributes.
/// </summary>
public interface QualifiedElement: IdentifiedElement, CollectionItem
{

  /// <summary>
  ///   Gets or sets the qualified identifier for this element.
  /// </summary>
    public string? QualifiedId { get; set; }
}