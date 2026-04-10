namespace DocumentModel.Vml;
/// <summary>
///   Complex.
/// </summary>
[OpenXmlType(typeof(DXVO.Complex))]
[XmlRoot("Complex", Namespace = "DocumentModel.Vml")]
public partial class Complex : ModelElement<DXVO.Complex>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Complex.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehavior? _Extension;
}