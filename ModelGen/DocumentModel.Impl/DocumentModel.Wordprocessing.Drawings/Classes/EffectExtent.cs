namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public class EffectExtentImpl: ModelElementImpl, EffectExtent
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  public Int64? LeftEdge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  public Int64? TopEdge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  public Int64? RightEdge
  {
    get;
    set;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  public Int64? BottomEdge
  {
    get;
    set;
  }
  
}
