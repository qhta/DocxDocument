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
  
  public EffectExtentImpl(): base() {}
  
  public EffectExtentImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  public Int64? LeftEdge
  {
    get => (Int64?)OpenXmlElement?.LeftEdge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeftEdge = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  public Int64? TopEdge
  {
    get => (Int64?)OpenXmlElement?.TopEdge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TopEdge = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  public Int64? RightEdge
  {
    get => (Int64?)OpenXmlElement?.RightEdge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightEdge = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  public Int64? BottomEdge
  {
    get => (Int64?)OpenXmlElement?.BottomEdge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BottomEdge = (System.Int64?)value;
    }
  }
  
}
