namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a content part embedded within a chart drawing that references external content through relationships.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a content part element that can embed external
///   content within a chart through relationship-based references. Content parts enable charts to incorporate rich
///   content such as images, diagrams, or other visual elements that are stored separately and referenced via
///   relationship identifiers. The content part includes properties for the relationship reference, black-and-white
///   mode rendering, non-visual properties (both content-specific and application-specific), 2D transformation for
///   positioning and sizing, and extensibility support. This architecture supports efficient content reuse across
///   multiple charts and documents while maintaining the chart's structure. Content parts are particularly useful
///   for including complex graphics, logos, or supplementary visual elements that enhance the chart's presentation
///   without embedding the actual content data directly within the chart definition.
///   This functionality is available in Office 2010 and later versions.
/// </remarks>
public interface ContentPart : IModelElement
{
  /// <summary>
  ///   Gets or sets the relationship identifier that references the external content.
  /// </summary>
  /// <value>
  ///   A string containing the relationship ID that links to the external content part,
  ///   or <c>null</c> if no relationship is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The relationship identifier establishes the connection between this content part element and the actual
  ///   content stored in a separate part of the document package. This ID corresponds to a relationship
  ///   defined in the document's relationship structure, enabling the chart to locate and access the
  ///   referenced content.
  /// </remarks>
  public string? RelationshipId { get; set; }

  /// <summary>
  ///   Gets or sets the black-and-white rendering mode for the content part.
  /// </summary>
  /// <value>
  ///   A <see cref="BlackWhiteMode"/> value specifying how the content should be rendered in black-and-white contexts,
  ///   or <c>null</c> to use the default rendering mode.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2010 and later.
  ///   The black-and-white mode determines how the content is displayed when printed or viewed in monochrome.
  ///   Different modes can preserve grayscale information, convert to pure black and white, or maintain
  ///   the original colors depending on the output requirements and visual preferences.
  /// </remarks>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   Gets or sets the non-visual properties specific to this content part.
  /// </summary>
  /// <value>
  ///   A <see cref="NonVisualContentPartProperties"/> object defining content-specific non-visual properties,
  ///   or <c>null</c> if no content part properties are specified.
  /// </value>
  /// <remarks>
  ///   Non-visual content part properties include metadata and behavioral characteristics that affect
  ///   how the content part functions but do not directly control its visual appearance. These properties
  ///   might include identifiers, names, descriptions, or interaction settings.
  /// </remarks>
  public NonVisualContentPartProperties? NonVisualContentPartProperties { get; set; }

  /// <summary>
  ///   Gets or sets the application-specific non-visual drawing properties for the content part.
  /// </summary>
  /// <value>
  ///   An <see cref="ApplicationNonVisualDrawingProperties"/> object defining application-level non-visual properties,
  ///   or <c>null</c> if no application properties are specified.
  /// </value>
  /// <remarks>
  ///   Application non-visual drawing properties include settings such as macro associations and publication
  ///   status that affect the content part's behavior within the application but are not part of its
  ///   visual representation. See <see cref="ApplicationNonVisualDrawingProperties"/> for details.
  /// </remarks>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   Gets or sets the 2D transformation applied to the content part for positioning and sizing.
  /// </summary>
  /// <value>
  ///   A <see cref="Transform2D"/> object defining the position, size, rotation, and flip transformations,
  ///   or <c>null</c> if no transformation is applied (using default positioning).
  /// </value>
  /// <remarks>
  ///   The 2D transformation controls where and how the content part appears within the chart area, including
  ///   its position coordinates, dimensions, rotation angle, and any flip operations. This enables precise
  ///   placement and sizing of the embedded content relative to other chart elements.
  /// </remarks>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   Gets or sets the collection of Office Art extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="OfficeArtExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Office Art extension elements allow for future enhancements to the content part functionality
  ///   without breaking compatibility with existing implementations. This enables new features and
  ///   properties to be added to content parts as Office evolves.
  /// </remarks>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}