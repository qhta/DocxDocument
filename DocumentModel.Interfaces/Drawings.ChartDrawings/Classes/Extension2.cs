namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents an extension element that enables future extensibility and custom functionality in chart drawings.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines an extension element that allows chart drawings
///   to include additional data, functionality, or features not defined in the base schema. Extensions are identified
///   by a URI (Uniform Resource Identifier) that specifies the namespace or type of the extension, enabling Office
///   applications to recognize and process custom extensions while maintaining backward compatibility with applications
///   that don't support them. This extensibility mechanism is fundamental to Office chart evolution, allowing new chart
///   types, visualization features, data binding methods, and formatting options to be added without breaking existing
///   documents or requiring schema changes that would invalidate older content. Extensions can contain custom XML data,
///   reference external schemas, or define chart-specific behaviors that extend the standard chart functionality. Common
///   uses include preview features before they become part of the core schema (such as new chart types like waterfall,
///   sunburst, or treemap), vendor-specific chart customizations, advanced charting capabilities for specialized domains
///   (financial, scientific, or engineering visualizations), and integration with external data sources or analytics
///   engines. Applications that don't recognize a particular extension URI can safely ignore the extension content,
///   ensuring charts remain functional even when opened in older or different Office versions. This forward-compatible
///   design enables innovation in chart visualization while preserving document interoperability across different Office
///   versions and platforms. The Extension2 interface is used throughout chart drawing structures via <see cref="ExtensionList"/>,
///   appearing in <see cref="Chart"/>, <see cref="ChartSpace"/>, <see cref="Axis"/>, <see cref="DataLabels"/>,
///   <see cref="DataPoint"/>, and many other chart components to provide consistent extensibility.
/// </remarks>
public interface Extension2 : IModelElement
{
  /// <summary>
  ///   Gets or sets the URI that identifies the type or namespace of this chart drawing extension.
  /// </summary>
  /// <value>
  ///   A string containing the URI identifier for the extension type,
  ///   or <c>null</c> if no URI is specified.
  /// </value>
  /// <remarks>
   ///   The URI serves as a unique identifier that specifies what type of chart extension this is and how it should
  ///   be processed. The URI typically follows a namespace format (e.g., "http://schemas.microsoft.com/office/drawing/2014/chartex"
  ///   for chart extensions, "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex" for advanced chart features)
  ///   that ensures uniqueness and provides context about the extension's origin and purpose. Office applications
  ///   use this URI to determine whether they can process the extension content. If an application recognizes the URI,
  ///   it can access and interpret the extension data to render advanced chart features; if not, it can safely ignore
  ///   the extension without affecting the chart's core functionality. This URI-based identification system is crucial
  ///   for maintaining chart compatibility across different Office versions and enabling incremental feature adoption
  ///   without requiring universal support for all extensions. For example, newer chart types introduced in Office 2016
  ///   (such as box and whisker, histogram, waterfall, or sunburst charts) use specific extension URIs that older versions
  ///   can recognize as unsupported features, allowing them to display fallback representations or simplified versions
  ///   while preserving the full chart definition for future use in capable applications.
  /// </remarks>
  public string? Uri { get; set; }
}