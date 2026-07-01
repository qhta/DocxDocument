namespace DocumentModel.Vml;
/// <summary>
///   Diagram Relationship Table.
/// </summary>
[OpenXmlType(typeof(DXVO.RelationTable))]
[DataContract]
[XmlRoot("RelationTable", Namespace = "DocumentModel.Vml")]
public partial class RelationTable : ModelElement<DXVO.RelationTable>
{
 /// <summary>
 ///   Collection of diagram relationships.
 /// </summary>
 public Relations? Relations { get => _Relations; set => UpdateField(ref _Relations, value, nameof(Relations)); }
 private Relations? _Relations;

 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.RelationTable.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }
 private ExtensionHandlingBehavior? _Extension;
}