namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a collection of child geographic entities within a hierarchical geographic structure.
/// </summary>
/// <remarks>
///   This class defines a collection of child geographic entities
///   that represent subdivisions within a parent geographic entity. Geographic entities are organized hierarchically,
///   with larger regions containing smaller subdivisions (such as countries containing states, states containing
///   counties, or provinces containing districts). This class provides access to the child entities at a
///   specific level of the geographic hierarchy, enabling drill-down navigation and hierarchical data visualization
///   in map-based charts. The collection is used within the <see cref = "Clear"/> structure as part of the
///   <see cref = "GeoChildEntitiesQueryResults"/> to cache hierarchical relationships between geographic entities.
///   This enables map charts to support interactive features such as drilling down from country-level data to
///   state-level data, or from state-level to county-level, providing progressively more detailed geographic
///   visualizations. Each <see cref = "GeoHierarchyEntity"/> in the collection represents a child geographic region
///   with its own properties, boundaries, and potential child entities, forming a tree structure that mirrors
///   real-world geographic containment relationships. Common hierarchical structures include: countries � states/provinces
///   � counties/districts � cities; continents � countries � regions; or custom geographic hierarchies for
///   specialized domains. The child entities collection supports map chart features like interactive region selection,
///   progressive detail display, and hierarchical data aggregation where data from smaller regions can be rolled up
///   to larger containing regions. This hierarchical organization is fundamental to creating intuitive, exploratory
///   map-based visualizations where users can navigate between different levels of geographic detail.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoChildEntities))]
[DataContract]
[XmlRoot("GeoChildEntities", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class GeoChildEntities : ModelElementCollection<GeoHierarchyEntity, DXO16DCD.GeoChildEntities, DXO16DCD.GeoHierarchyEntity>
{
}