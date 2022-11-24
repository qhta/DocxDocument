namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Lattice Class.
/// </summary>
public interface ILattice // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// initial
  /// </summary>
  public Int32? Initial { get ; set; }
  
  /// <summary>
  /// final
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.DecimalValue>? Final { get ; set; }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public String? TimeReference { get ; set; }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public AnchorPointValues? TimeReferenceAnchorPoint { get ; set; }
  
}
