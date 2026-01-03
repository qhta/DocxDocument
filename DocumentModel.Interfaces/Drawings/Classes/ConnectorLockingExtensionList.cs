namespace DocumentModel.Drawings;

/// <summary>
/// Represents a collection of extensions that define advanced locking behaviors and constraints
/// for connector shapes in DrawingML diagrams. Connector locking extensions enable sophisticated
/// connection management, routing constraints, and attachment rules that go beyond standard
/// connector properties, supporting complex diagram scenarios and future connector enhancements.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="ConnectorLockingExtensionList"/> is a specialized extension mechanism for connector shapes
/// (lines that connect other shapes in diagrams, flowcharts, and organizational charts). Connectors are
/// fundamental to creating structured diagrams, and connector locking extensions enable:
/// <list type="bullet">
/// <item><description><b>Advanced attachment rules:</b> Define how connectors attach to and interact with connected shapes</description></item>
/// <item><description><b>Routing constraints:</b> Control automatic connector routing and rerouting behavior</description></item>
/// <item><description><b>Connection point locking:</b> Prevent connectors from detaching or moving from specific points</description></item>
/// <item><description><b>Relationship preservation:</b> Maintain connections when shapes move, resize, or are rearranged</description></item>
/// <item><description><b>Custom routing algorithms:</b> Specify preferred routing paths or algorithms for specific connectors</description></item>
/// <item><description><b>Future enhancements:</b> Support new connector features added in newer Office versions</description></item>
/// </list>
/// </para>
/// <para>
/// Connector locking extensions differ from other DrawingML extension types:
/// <list type="bullet">
/// <item><description><b>ConnectorLockingExtensionList:</b> Specific to connector shape locking and attachment behavior</description></item>
/// <item><description><b>ShapeLockingExtensionList:</b> General shape locking (preventing move, resize, delete of any shape)</description></item>
/// <item><description><b>OfficeArtExtensionList:</b> General DrawingML extensions for visual effects and formatting</description></item>
/// <item><description><b>BlipExtensionList:</b> Specific to image/picture extensions</description></item>
/// </list>
/// This specialization allows connector-specific locking behaviors to be defined independently from
/// other shape properties, enabling complex diagram management scenarios.
/// </para>
/// <para>
/// Connectors in Office documents are used extensively in:
/// <list type="bullet">
/// <item><description><b>Flowcharts:</b> Process flows with decision points, branches, and sequential steps</description></item>
/// <item><description><b>Organization charts:</b> Hierarchical relationships between positions or departments</description></item>
/// <item><description><b>Network diagrams:</b> System architectures, network topologies, infrastructure layouts</description></item>
/// <item><description><b>Mind maps:</b> Concept relationships and idea hierarchies</description></item>
/// <item><description><b>UML diagrams:</b> Class relationships, sequence diagrams, state machines</description></item>
/// <item><description><b>Data flow diagrams:</b> Information flow between systems or processes</description></item>
/// <item><description><b>SmartArt graphics:</b> Automatically managed connector relationships</description></item>
/// </list>
/// </para>
/// <para>
/// Common connector locking scenarios include:
/// <list type="bullet">
/// <item><description><b>Fixed connections:</b> Prevent connectors from detaching when shapes move</description></item>
/// <item><description><b>Locked routing:</b> Prevent automatic rerouting of connectors (maintain manual routing)</description></item>
/// <item><description><b>Connection point constraints:</b> Restrict which connection points connectors can use</description></item>
/// <item><description><b>Relationship preservation:</b> Maintain logical connections during diagram reorganization</description></item>
/// <item><description><b>Template enforcement:</b> Ensure connectors follow diagram template rules</description></item>
/// <item><description><b>Protected diagrams:</b> Lock connector topology in approved diagrams</description></item>
/// </list>
/// </para>
/// <para>
/// Applications processing connector locking extensions should:
/// <list type="bullet">
/// <item><description><b>Respect locking constraints:</b> Prevent operations that violate connector locks</description></item>
/// <item><description><b>Maintain connections:</b> Keep connectors attached during shape manipulation</description></item>
/// <item><description><b>Preserve routing:</b> Don't automatically reroute locked connectors</description></item>
/// <item><description><b>Handle gracefully:</b> Provide feedback when operations are blocked by locks</description></item>
/// <item><description><b>Round-trip unknown extensions:</b> Preserve unrecognized extensions for compatibility</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Lock connector endpoints to prevent detachment
/// var lockedConnector = new ConnectorLockingExtensionList
/// {
///     ConnectorLockingExtensions = new Collection&lt;ConnectorLockingExtension&gt;
///     {
///         new ConnectorLockingExtension
///         {
///             Uri = "{ConnectorEndpointLock}",
///             // Prevents start and end points from detaching
///         }
///     }
/// };
/// 
/// // Lock connector routing to preserve manual layout
/// var lockedRouting = new ConnectorLockingExtensionList
/// {
///     ConnectorLockingExtensions = new Collection&lt;ConnectorLockingExtension&gt;
///     {
///         new ConnectorLockingExtension
///         {
///             Uri = "{ConnectorRoutingLock}",
///             // Prevents automatic rerouting
///         }
///     }
/// };
/// </code>
/// </example>
public interface ConnectorLockingExtensionList : IModelElement
{
  /// <summary>
  /// Gets or sets the collection of connector locking extensions that define attachment constraints,
  /// routing rules, and protection settings for connector shapes in diagrams.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The collection of connector locking extensions provides fine-grained control over connector
  /// behavior in diagrams, flowcharts, and organizational charts. Each extension represents a specific
  /// locking constraint or behavior rule, such as:
  /// <list type="bullet">
  /// <item><description><b>Endpoint locking:</b> Prevent connector start/end points from detaching from shapes</description></item>
  /// <item><description><b>Routing locks:</b> Prevent automatic rerouting, maintain manual connector paths</description></item>
  /// <item><description><b>Connection point constraints:</b> Restrict which connection points can be used</description></item>
  /// <item><description><b>Style protection:</b> Lock connector line style, arrows, and formatting</description></item>
  /// <item><description><b>Relationship enforcement:</b> Maintain logical connections during diagram changes</description></item>
  /// <item><description><b>SmartArt management:</b> Special behaviors for SmartArt-managed connectors</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Applications working with connector locking extensions should:
  /// <list type="bullet">
  /// <item><description><b>Check locks before operations:</b> Validate that operations don't violate locking constraints</description></item>
  /// <item><description><b>Provide feedback:</b> Inform users when operations are blocked by connector locks</description></item>
  /// <item><description><b>Respect SmartArt locks:</b> Don't manually modify SmartArt-managed connectors</description></item>
  /// <item><description><b>Maintain during edits:</b> Keep connector locks valid during shape manipulation</description></item>
  /// <item><description><b>Preserve unknown extensions:</b> Round-trip unrecognized extensions for compatibility</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public Collection<ConnectorLockingExtension>? ConnectorLockingExtensions { get; set; }
}