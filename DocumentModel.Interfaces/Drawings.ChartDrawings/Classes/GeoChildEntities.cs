namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of child geographic entities within a hierarchical geographic structure.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a collection of child geographic entities
///   that represent subdivisions within a parent geographic entity. Geographic entities are organized hierarchically,
///   with larger regions containing smaller subdivisions (such as countries containing states, states containing
///   counties, or provinces containing districts). This interface provides access to the child entities at a
///   specific level of the geographic hierarchy, enabling drill-down navigation and hierarchical data visualization
///   in map-based charts. The collection is used within the <see cref="Clear"/> structure as part of the
///   <see cref="GeoChildEntitiesQueryResults"/> to cache hierarchical relationships between geographic entities.
///   This enables map charts to support interactive features such as drilling down from country-level data to
///   state-level data, or from state-level to county-level, providing progressively more detailed geographic
///   visualizations. Each <see cref="GeoHierarchyEntity"/> in the collection represents a child geographic region
///   with its own properties, boundaries, and potential child entities, forming a tree structure that mirrors
///   real-world geographic containment relationships. Common hierarchical structures include: countries → states/provinces
///   → counties/districts → cities; continents → countries → regions; or custom geographic hierarchies for
///   specialized domains. The child entities collection supports map chart features like interactive region selection,
///   progressive detail display, and hierarchical data aggregation where data from smaller regions can be rolled up
///   to larger containing regions. This hierarchical organization is fundamental to creating intuitive, exploratory
///   map-based visualizations where users can navigate between different levels of geographic detail.
/// </remarks>
public interface GeoChildEntities : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of child geographic entities in the hierarchy.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="GeoHierarchyEntity"/> objects representing child geographic regions,
  ///   or <c>null</c> if no child entities are defined.
  /// </value>
  /// <remarks>
  ///   Each <see cref="GeoHierarchyEntity"/> in the collection represents a geographic region that is contained
  ///   within a parent entity, such as states within a country or counties within a state. The collection enables
  ///   hierarchical navigation in map charts, where selecting a parent region can reveal or drill down to show
  ///   its child regions with more detailed data visualization. For example, clicking on "United States" might
  ///   reveal data for individual states, or clicking on "California" might show data for individual counties.
  ///   The hierarchical structure supports various geographic data operations including data aggregation (rolling
  ///   up child values to parent totals), progressive detail display (showing more granular data as users drill
  ///   down), and context preservation (maintaining awareness of the current position in the geographic hierarchy).
  ///   The collection may be populated from cached geographic query results stored in <see cref="GeoCache"/>,
  ///   enabling offline access to hierarchical geographic relationships without requiring repeated queries to
  ///   external mapping services.
  /// </remarks>
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
}