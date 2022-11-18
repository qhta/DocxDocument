namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Lattice Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IArc))]
[ChildElementInfo(typeof(DocumentModel.EMMA.INode))]
public interface ILattice // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// initial
  /// </summary>
  public int? Initial { get ; set; }
  
  /// <summary>
  /// final
  /// </summary>
  public List<decimal>? Final { get ; set; }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public string? TimeReference { get ; set; }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public AnchorPoint? TimeReferenceAnchorPoint { get ; set; }
  
}
