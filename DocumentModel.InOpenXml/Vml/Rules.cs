namespace DocumentModel.Vml;
/// <summary>
///   Rule Set.
/// </summary>
[OpenXmlType(typeof(DXVO.Rules))]
[XmlRoot("Rules", Namespace = "DocumentModel.Vml")]
public partial class Rules : ModelElementCollection<Rule, DXVO.Rules, DXVO.Rule>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 public ExtensionHandlingBehavior? Extension { [DebuggerStepThrough] get => _Extension; [DebuggerStepThrough] set => UpdateField(ref _Extension, value, nameof(Extension)); }
 private ExtensionHandlingBehavior? _Extension;

}