namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public interface IEffectExtent // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  public Int64? LeftEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  public Int64? TopEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  public Int64? RightEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  public Int64? BottomEdge { get ; set; }
  
}
