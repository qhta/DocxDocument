namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a basic geographic entity reference with identification information.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a lightweight geographic entity representation
///   that provides basic identification through a name and type classification. Unlike <see cref="GeoData"/> which
///   contains comprehensive geographic information including boundaries, coordinates, and polygons, GeoEntity provides
///   minimal entity identification suitable for references, lists, or scenarios where full geographic detail is not
///   required. This lightweight structure is particularly valuable in geographic hierarchies, query results, or
///   entity collections where only identification and classification information is needed without the overhead of
///   complete boundary and coordinate data. The entity name (<see cref="EntityName"/>) provides human-readable
///   identification for display and user interaction, while the entity type (<see cref="EntityType"/>) specifies
///   the administrative or geographic classification level (such as country, state, county, or city). Geographic
///   entities are used throughout the chart drawing geographic data structures to reference regions in hierarchical
///   relationships (via <see cref="GeoHierarchyEntity"/>), query specifications (such as <see cref="GeoChildEntitiesQuery"/>),
///   and result collections. The minimal structure promotes efficient memory usage and fast processing when working
///   with large numbers of geographic references, such as listing all states in a country or all counties in a state.
///   When detailed geographic information is needed for rendering or spatial operations, the entity can be used as
///   a reference to query for complete <see cref="GeoData"/> containing boundaries and coordinates. This separation
///   between lightweight entity references and detailed geographic data enables flexible, efficient geographic data
///   management in map-based chart visualizations.
/// </remarks>
public interface GeoEntity : IModelElement
{
  /// <summary>
  ///   Gets or sets the human-readable name of the geographic entity.
  /// </summary>
  /// <remarks>
   ///   The entity name provides a user-friendly identifier for the geographic entity, such as "United States",
  ///   "California", "Los Angeles County", or "Tokyo". This name is used for display purposes in user interfaces,
  ///   chart labels, dropdown lists, navigation hierarchies, and other contexts where the entity needs to be
  ///   presented to users in a readable, recognizable format. The name may be localized based on the document's
  ///   language settings or user preferences, providing appropriate regional naming conventions. Unlike entity
  ///   identifiers which are machine-readable codes, the entity name is designed for human readability and may
  ///   contain spaces, special characters, and localized text. The entity name works in conjunction with
  ///   <see cref="EntityType"/> to provide complete entity identification, where the name specifies which entity
  ///   and the type specifies what kind of entity it is (country, state, city, etc.).
  /// </remarks>
  public string? EntityName { get; set; }

  /// <summary>
  ///   Gets or sets the classification type of the geographic entity.
  /// </summary>
  /// <remarks>
   ///   The entity type specifies the classification level of the geographic entity within administrative or
  ///   geographic hierarchies, such as country, first-level administrative division (state/province), second-level
  ///   administrative division (county/district), populated place (city/town), or other geographic classifications.
  ///   This type information is essential for understanding the entity's position in geographic hierarchies and
  ///   for disambiguating entities that might have the same name at different administrative levels. For example,
  ///   the type distinguishes "Georgia" the country (type: Country) from "Georgia" the U.S. state (type: AdminDivision1).
  ///   The entity type enables proper organization and filtering of geographic entities in hierarchical structures,
  ///   supports appropriate drill-down navigation in map charts, and ensures correct interpretation of entity
  ///   relationships. The type works in conjunction with <see cref="EntityName"/> to provide complete entity
  ///   identification, enabling accurate entity reference and retrieval in geographic data operations.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }
}