namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public partial class EffectExtentImpl: ModelElementImpl, EffectExtent
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.Int64?)OpenXmlElement?.LeftEdge?.Value;
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
    get => (System.Int64?)OpenXmlElement?.TopEdge?.Value;
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
    get => (System.Int64?)OpenXmlElement?.RightEdge?.Value;
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
    get => (System.Int64?)OpenXmlElement?.BottomEdge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BottomEdge = (System.Int64?)value;
    }
  }
  
}
