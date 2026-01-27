namespace DocumentModel;
/// <summary>
///   Represents a single content choice within an alternate content container, selected when specific requirements are met.
/// </summary>
/// <remarks>
///   This class defines a content choice option within an <see cref = "AlternateContent"/>
///   structure. Each choice represents a specific way to render or represent content, associated with requirements
///   that must be met for the choice to be selected. The requirements, specified through the <see cref = "Requires"/>
///   property, typically identify namespaces, features, or capabilities that the application must support to use
///   this choice's content. When an Office application processes alternate content, it evaluates each choice in
///   the order they appear, checking whether the application satisfies the choice's requirements. The first choice
///   whose requirements are met is selected and its content is rendered. Common requirements include namespace URIs
///   that indicate support for specific XML schemas or content types (such as "http://schemas.microsoft.com/office/drawing/2014/chartex"
///   for chart extensions), feature identifiers, or version-specific capabilities. The choice contains a collection
///   of content items that represent the actual content to display when this choice is selected. This mechanism
///   enables documents created with newer Office versions to include advanced features while maintaining compatibility
///   with older versions through the alternate content fallback mechanism. For example, a choice might require
///   3D model support and contain a 3D shape, while a fallback provides a 2D image for older applications.
/// </remarks>
[OpenXmlType(typeof(DX.AlternateContentChoice))]
public partial class AlternateContentChoice : ModelElement<DX.AlternateContentChoice> //, IElementCollection<ModelElement>
{
 /// <summary>
 ///   Gets or sets the requirement condition that must be satisfied for this choice to be selected.
 /// </summary>
 /// <remarks>
 ///   This property specifies the condition that an application must meet to use this choice's content.
 ///   The value is typically a namespace UriString that identifies a specific XML schema, content type, or feature set
 ///   that the application must support. For example, "http://schemas.microsoft.com/office/word/2010/wordml"
 ///   indicates that the application must support Word 2010 features, or "http://schemas.openxmlformats.org/drawingml/2006/picture"
 ///   indicates picture support. When an application encounters alternate content, it evaluates this requirement
 ///   by checking if it recognizes and can process the specified namespace or feature. If the requirement is
 ///   satisfied, this choice's content is used; otherwise, the application continues to the next choice or falls
 ///   back to the <see cref = "AlternateContent.Fallback"/> content. Multiple requirements can sometimes be specified
 ///   using space-separated namespace URIs, indicating that all listed namespaces must be supported. This
 ///   requirement-based selection mechanism is fundamental to Office's forward compatibility, allowing new features
 ///   to be introduced while ensuring documents remain functional in older application versions.
 /// </remarks>
 [OpenXmlProperty(nameof(DX.AlternateContentChoice.Requires))]
 public string? Requires { get => _Requires; set => UpdateField(ref _Requires, value, nameof(Requires)); }

 private string? _Requires;
}