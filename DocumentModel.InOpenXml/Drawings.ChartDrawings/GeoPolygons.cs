namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a collection of polygons that define the complete geographic boundaries of an entity.
/// </summary>
/// <remarks>
///   This class extends <see cref = "ElementCollection{ItemType}"/> of <see cref = "GeoPolygon"/> and defines a collection
///   of geometric polygons that together represent the complete boundary shape of a geographic entity. Geographic
///   entities often require multiple polygons to accurately represent their boundaries due to various geographic
///   features including disconnected territories (such as archipelagos, overseas territories, or non-contiguous regions),
///   interior exclusions (such as lakes, enclaves, or holes within the boundary), and complex coastlines or borders
///   that may be divided into multiple segments for efficient rendering or data management. The polygon collection is
///   used within <see cref = "GeoData"/> to provide detailed, accurate boundary definitions for countries, states, regions,
///   or other geographic entities displayed in map-based charts. Each <see cref = "GeoPolygon"/> in the collection contains
///   encoded coordinate data defining a boundary component, with the collection as a whole forming the complete entity
///   shape. The multiple-polygon structure supports various geographic scenarios: island nations where each major island
///   is represented by a separate polygon, countries with overseas territories that are geographically separated from the
///   mainland, regions with interior water bodies (lakes) that create holes in the landmass, or administrative boundaries
///   divided into segments for optimized storage and rendering. The polygon collection enables accurate visualization of
///   complex geographic entities in map charts, supporting features such as region coloring (choropleth maps), boundary
///   rendering, point-in-region tests, and spatial operations. Different polygons in the collection may represent different
///   levels of detail, with simplified low-resolution polygons for overview display and detailed high-resolution polygons
///   for zoomed views. The collection structure allows efficient management of boundary data where different polygon
///   components can be loaded, cached, or rendered independently based on visualization requirements, zoom levels, or
///   performance constraints.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoPolygons))]
[XmlRoot("GeoPolygons", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class GeoPolygons : ModelElementCollection<GeoPolygon, DXO16DCD.GeoPolygons, DXO16DCD.GeoPolygon>
{
}