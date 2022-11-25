namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Lattice Class.
/// </summary>
public interface ILattice // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// initial
  /// </summary>
  public System.Int32? Initial { get ; set; }
  
  /// <summary>
  /// final
  /// </summary>
  public System.Collections.Generic.List<System.Decimal>? Final { get ; set; }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public System.String? TimeReference { get ; set; }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public DocumentModel.EMMA.AnchorPointKind? TimeReferenceAnchorPoint { get ; set; }
  
}
