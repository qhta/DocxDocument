namespace DocumentModel.Vml;
/// <summary>
///   Diagram Relationship Table.
/// </summary>
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
    public ExtensionHandlingBehaviorKind? Extension { get; set; }
}