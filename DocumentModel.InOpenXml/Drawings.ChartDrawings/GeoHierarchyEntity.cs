namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a geographic entity within a hierarchical structure, providing identification and classification for parent-child geographic relationships.
/// </summary>
/// <remarks>
///   This class defines a geographic entity that participates in hierarchical
///   geographic relationships, such as parent-child containment structures used in map-based chart drill-down navigation.
///   Unlike the basic <see cref = "GeoEntity"/> which provides only name and type, GeoHierarchyEntity includes a unique
///   identifier (<see cref = "EntityId"/>) enabling precise entity reference and correlation across geographic queries and
///   data operations. This enhanced structure is essential for hierarchical geographic visualizations where entities need
///   to be uniquely identified for parent-child relationship mapping, drill-down navigation, and data aggregation. The
///   entity combines human-readable identification (<see cref = "EntityName"/>), machine-readable unique reference
///   (<see cref = "EntityId"/>), and administrative classification (<see cref = "EntityType"/>) to provide complete entity
///   information suitable for hierarchical operations. Geographic hierarchy entities are used extensively in parent-child
///   relationship structures, appearing in <see cref = "GeoChildEntities"/> collections that represent subdivisions within
///   parent regions (such as states within a country or counties within a state). This hierarchical structure enables
///   interactive map chart features including drill-down from larger regions to their constituent parts, roll-up aggregation
///   of data from smaller regions to larger containing regions, and navigation through multiple levels of geographic detail.
///   The unique entity identifier is crucial for maintaining consistent entity references across different geographic
///   operations, enabling efficient cache lookup, supporting data binding between chart data and geographic entities, and
///   facilitating hierarchical navigation where entities at one level need to reference their parent or child entities at
///   other levels. The hierarchical entity structure supports various geographic hierarchy models including administrative
///   hierarchies (country Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ state Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ county Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ city), statistical hierarchies (continent Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ country Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„ region), or custom
///   domain-specific hierarchies tailored to particular analytical or business requirements.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.GeoHierarchyEntity))]
public class GeoHierarchyEntity: ModelElement<DXO16DCD.GeoHierarchyEntity>
{
  /// <summary>
  /// Specifies the entity name.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoHierarchyEntity.EntityName))]
  public string? EntityName { get => _EntityName; set => UpdateField(ref _EntityName, value, nameof(EntityName)); }
  private string? _EntityName;
  /// <summary>
  /// Specifies the entity id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoHierarchyEntity.EntityId))]
  public string? EntityId { get => _EntityId; set => UpdateField(ref _EntityId, value, nameof(EntityId)); }
  private string? _EntityId;
  /// <summary>
  /// Specifies the entity type.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.GeoHierarchyEntity.EntityType))]
  public EntityTypeEnum? EntityType
  {
    get => _EntityType;
    set => UpdateField(ref _EntityType, value, nameof(EntityType));
  }
  private EntityTypeEnum? _EntityType;
}