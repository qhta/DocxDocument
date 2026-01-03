namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of extension elements that enable future extensibility for chart drawings.
/// </summary>
/// <remarks>
///   This interface defines a container for extension elements that
///   allow chart drawings to include additional data, functionality, or features not defined in the base schema.
///   The ExtensionList serves as an extensibility mechanism throughout chart drawing objects, enabling Office
///   applications to introduce new features, custom properties, or enhanced capabilities without requiring schema
///   changes that would invalidate existing documents. Each <see cref="Extension2"/> in the collection is identified
///   by a URI that specifies the namespace or type of the extension, allowing applications to recognize and process
///   supported extensions while safely ignoring unknown ones. This architecture is fundamental to the evolution of
///   chart functionality in Office, enabling new chart types, visualization features, data binding methods, and
///   formatting options to be introduced incrementally. Common uses include preview features before they become part
///   of the core schema, vendor-specific customizations, advanced charting capabilities for specialized domains, and
///   integration with external data sources or analytics engines. The extension mechanism ensures forward compatibility:
///   when a document with extensions is opened in an older Office version that doesn't recognize certain extension
///   URIs, those extensions are preserved but not processed, allowing the document to remain functional and enabling
///   full feature restoration when subsequently opened in a capable application. This design pattern appears throughout
///   chart drawing interfaces (<see cref="Chart"/>, <see cref="ChartSpace"/>, <see cref="Axis"/>, <see cref="DataLabels"/>,
///   etc.), providing consistent extensibility across all chart components.
/// </remarks>
public interface ExtensionList : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of extension elements.
  /// </summary>
  /// <remarks>
  ///   Each <see cref="Extension2"/> in the collection represents a specific extension with a unique URI identifier
  ///   that specifies the extension's type, namespace, and processing requirements. The collection enables multiple
  ///   extensions to coexist within the same chart element, supporting scenarios where different features, customizations,
  ///   or preview capabilities are combined. Extensions are processed based on their URI: if an application recognizes
  ///   the URI, it can access and interpret the extension data; if not, the extension is preserved but ignored,
  ///   maintaining document integrity across different Office versions and ensuring no data loss during roundtrips
  ///   between applications with varying levels of extension support.
  /// </remarks>
  public Collection<Extension2>? Extensions { get; set; }
}