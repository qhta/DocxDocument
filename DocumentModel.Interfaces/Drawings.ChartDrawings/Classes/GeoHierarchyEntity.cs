namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a geographic entity within a hierarchical structure, providing identification and classification for parent-child geographic relationships.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a geographic entity that participates in hierarchical
///   geographic relationships, such as parent-child containment structures used in map-based chart drill-down navigation.
///   Unlike the basic <see cref="GeoEntity"/> which provides only name and type, GeoHierarchyEntity includes a unique
///   identifier (<see cref="EntityId"/>) enabling precise entity reference and correlation across geographic queries and
///   data operations. This enhanced structure is essential for hierarchical geographic visualizations where entities need
///   to be uniquely identified for parent-child relationship mapping, drill-down navigation, and data aggregation. The
///   entity combines human-readable identification (<see cref="EntityName"/>), machine-readable unique reference
///   (<see cref="EntityId"/>), and administrative classification (<see cref="EntityType"/>) to provide complete entity
///   information suitable for hierarchical operations. Geographic hierarchy entities are used extensively in parent-child
///   relationship structures, appearing in <see cref="GeoChildEntities"/> collections that represent subdivisions within
///   parent regions (such as states within a country or counties within a state). This hierarchical structure enables
///   interactive map chart features including drill-down from larger regions to their constituent parts, roll-up aggregation
///   of data from smaller regions to larger containing regions, and navigation through multiple levels of geographic detail.
///   The unique entity identifier is crucial for maintaining consistent entity references across different geographic
///   operations, enabling efficient cache lookup, supporting data binding between chart data and geographic entities, and
///   facilitating hierarchical navigation where entities at one level need to reference their parent or child entities at
///   other levels. The hierarchical entity structure supports various geographic hierarchy models including administrative
///   hierarchies (country → state → county → city), statistical hierarchies (continent → country → region), or custom
///   domain-specific hierarchies tailored to particular analytical or business requirements.
/// </remarks>
public interface GeoHierarchyEntity : IModelElement
{
  /// <summary>
  ///   Gets or sets the human-readable name of the geographic entity.
  /// </summary>
  /// <value>
  ///   A string containing the entity's display name,
  ///   or <c>null</c> if no name is specified.
  /// </value>
  /// <remarks>
   ///   The entity name provides a user-friendly identifier for the geographic entity that is suitable for display
  ///   in user interfaces, chart labels, drill-down navigation menus, hierarchical lists, and other contexts where
  ///   the entity needs to be presented to users in a readable, recognizable format. Examples include "United States",
  ///   "California", "Los Angeles County", or "San Francisco". The name may be localized based on culture settings
  ///   specified in <see cref="Geography.CultureLanguage"/>, providing appropriate regional naming conventions and
  ///   language preferences. The entity name is used in conjunction with <see cref="EntityId"/> for complete entity
  ///   identification, where the name provides human readability and the ID provides unique machine reference. In
  ///   hierarchical structures, the name helps users understand the geographic containment relationships and navigate
  ///   through different levels of detail (such as drilling from "United States" to "California" to "Los Angeles County").
  /// </remarks>
  public string? EntityName { get; set; }

  /// <summary>
  ///   Gets or sets the unique identifier for the geographic entity.
  /// </summary>
  /// <value>
  ///   A string containing the entity's unique identifier,
  ///   or <c>null</c> if no identifier is specified.
  /// </value>
  /// <remarks>
   ///   The entity identifier provides a unique, machine-readable reference for the geographic entity that remains
  ///   consistent across different operations, queries, and data sources. Common identifier formats include ISO country
  ///   codes (e.g., "US", "GB", "JP" for countries), administrative division codes (e.g., "US-CA" for California,
  ///   "US-NY" for New York), or provider-specific entity identifiers. The unique identifier is essential for several
  ///   hierarchical operations: (1) establishing parent-child relationships where child entities reference their parent
  ///   entity by ID, (2) enabling efficient cache lookup in <see cref="GeoCache"/> where entities are stored and
  ///   retrieved by their identifiers, (3) supporting data binding where chart data points reference geographic entities
  ///   through entity IDs rather than potentially ambiguous names, (4) facilitating drill-down navigation where selecting
  ///   a parent entity triggers queries for child entities identified by their parent's ID, and (5) enabling data
  ///   aggregation where values from child entities are rolled up to their parent entities using ID-based relationships.
  ///   The identifier format depends on the geographic data provider specified in <see cref="GeoCache.Provider"/>,
  ///   ensuring consistency with the provider's entity identification system and enabling reliable entity reference
  ///   across all geographic operations.
  /// </remarks>
  public string? EntityId { get; set; }

  /// <summary>
  ///   Gets or sets the classification type of the geographic entity.
  /// </summary>
  /// <value>
  ///   An <see cref="EntityTypeEnum"/> value specifying the entity's administrative or geographic classification,
  ///   or <c>null</c> if no type is specified.
  /// </value>
  /// <remarks>
   ///   The entity type specifies the administrative or geographic classification level of the entity within hierarchical
  ///   structures, such as country, first-level administrative division (state/province), second-level administrative
  ///   division (county/district), populated place (city/town), or other classifications. This type information is
  ///   crucial for hierarchical operations including: (1) determining valid parent-child relationships (such as knowing
  ///   that counties can be children of states but not vice versa), (2) supporting appropriate drill-down navigation
  ///   where users progress through logical hierarchy levels (country → state → county rather than arbitrary jumps),
  ///   (3) disambiguating entities with the same name at different administrative levels (such as "Georgia" the country
  ///   vs. "Georgia" the U.S. state), (4) filtering child entity queries by type to retrieve only specific administrative
  ///   levels (as seen in <see cref="GeoChildEntitiesQuery.GeoChildTypes"/>), and (5) organizing geographic entities
  ///   in hierarchy visualizations with proper level-based grouping and indentation. The entity type enables the chart
  ///   to understand the position of each entity within the overall geographic hierarchy, ensuring logical, intuitive
  ///   navigation patterns and appropriate data aggregation across hierarchy levels.
  /// </remarks>
  public EntityTypeEnum? EntityType { get; set; }
}