using DocumentModel.Drawings.Office.ScriptLink;

namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for non-visual drawing properties, providing additional metadata and configuration options.
/// </summary>
[OpenXmlType(typeof(DXD.NonVisualDrawingPropertiesExtension))]
public partial class NonVisualDrawingPropertiesExtension<T>: ModelElement<T>, IExtension where T: DX.OpenXmlElement
{
 /// <summary>
 ///   Compatibility extension for handling legacy or platform-specific features.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public CompatExtension? CompatExtension { get => _CompatExtension; set => UpdateField(ref _CompatExtension, value, nameof(CompatExtension)); }

 private CompatExtension? _CompatExtension;
 /// <summary>
 ///   Background properties for the drawing element.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public BackgroundProperties? BackgroundProperties { get => _BackgroundProperties; set => UpdateField(ref _BackgroundProperties, value, nameof(BackgroundProperties)); }

 private BackgroundProperties? _BackgroundProperties;
 /// <summary>
 ///   Unique creation identifier for the drawing element.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public CreationId? CreationId { get => _CreationId; set => UpdateField(ref _CreationId, value, nameof(CreationId)); }

 private CreationId? _CreationId;
 /// <summary>
 ///   Reference to a predecessor drawing element.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public PredecessorDrawingElementReference? PredecessorDrawingElementReference { get => _PredecessorDrawingElementReference; set => UpdateField(ref _PredecessorDrawingElementReference, value, nameof(PredecessorDrawingElementReference)); }

 private PredecessorDrawingElementReference? _PredecessorDrawingElementReference;
 /// <summary>
 ///   Indicates whether the element is decorative.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public bool? Decorative { get => _Decorative; set => UpdateField(ref _Decorative, value, nameof(Decorative)); }

 private bool? _Decorative;
 /// <summary>
 ///   Classification outcome for accessibility or categorization.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public ClassificationOutcome? ClassificationOutcome { get => _ClassificationOutcome; set => UpdateField(ref _ClassificationOutcome, value, nameof(ClassificationOutcome)); }

 private ClassificationOutcome? _ClassificationOutcome;
 /// <summary>
 ///   Script link associated with the drawing element.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public ScriptLink? ScriptLink { get => _ScriptLink; set => UpdateField(ref _ScriptLink, value, nameof(ScriptLink)); }

 private ScriptLink? _ScriptLink;
 /// <summary>
 /// Uri string associated with the extension.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.NonVisualDrawingPropertiesExtension.Uri))]
 [OpenXmlElement(typeof(DXD.NonVisualDrawingPropertiesExtension))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}