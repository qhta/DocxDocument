namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LinePropertiesType Class.
/// </summary>
public class LinePropertiesTypeImpl: ModelElementImpl, LinePropertiesType
{
  public DocumentFormat.OpenXml.Drawing.LinePropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinePropertiesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// line width
  /// </summary>
  public Int32? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  public LineCapKind? CapType
  {
    get => (LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Drawing.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType
  {
    get => (CompoundLineKind?)OpenXmlElement?.CompoundLineType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompoundLineType = (DocumentFormat.OpenXml.Drawing.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment
  {
    get => (PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.PenAlignmentValues?)value;
    }
  }
  
}
