namespace DocumentModel.Vml;
/// <summary>
///   Rule Set.
/// </summary>
[OpenXmlType(typeof(Rule))]
[XmlRoot("Rules", Namespace = "DocumentModel.Vml")]
public partial class Rules : ModelElementCollection<Rule, DXVO.Rules, DXVO.Rule>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 public ExtensionHandlingBehavior? Extension { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}