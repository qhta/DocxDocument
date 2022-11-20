namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public interface IEffectExtent // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  public long? LeftEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  public long? TopEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  public long? RightEdge { get ; set; }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  public long? BottomEdge { get ; set; }
  
}
