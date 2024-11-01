namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public partial class LinePropertiesTypeImpl: ModelElementImpl, LinePropertiesType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.LinePropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinePropertiesType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LinePropertiesTypeImpl(): base() {}
  
  public LinePropertiesTypeImpl(DocumentFormat.OpenXml.Drawing.LinePropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width
  {
    get => (System.Int32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  public DocumentModel.Drawings.LineCapKind? CapType
  {
    get => (DocumentModel.Drawings.LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Drawing.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public DocumentModel.Drawings.CompoundLineKind? CompoundLineType
  {
    get => (DocumentModel.Drawings.CompoundLineKind?)OpenXmlElement?.CompoundLineType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompoundLineType = (DocumentFormat.OpenXml.Drawing.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public DocumentModel.Drawings.PenAlignmentKind? Alignment
  {
    get => (DocumentModel.Drawings.PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.PenAlignmentValues?)value;
    }
  }
  
}
