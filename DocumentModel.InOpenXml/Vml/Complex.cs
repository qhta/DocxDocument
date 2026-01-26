namespace DocumentModel.Vml;
/// <summary>
///   Complex.
/// </summary>
[OpenXmlType(typeof(DXVO.Complex))]
public partial class Complex : ModelElement<DXVO.Complex>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Complex.Extension))]
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlElement(typeof(DXVO.Complex))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
}