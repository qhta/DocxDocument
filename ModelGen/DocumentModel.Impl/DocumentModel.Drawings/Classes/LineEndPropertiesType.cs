namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public partial class LineEndPropertiesTypeImpl: ModelElementImpl, LineEndPropertiesType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineEndPropertiesType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LineEndPropertiesTypeImpl(): base() {}
  
  public LineEndPropertiesTypeImpl(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public DocumentModel.Drawings.LineEndKind? Type
  {
    get => (DocumentModel.Drawings.LineEndKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.LineEndValues?)value;
    }
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public DocumentModel.Drawings.LineEndWidthKind? Width
  {
    get => (DocumentModel.Drawings.LineEndWidthKind?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (DocumentFormat.OpenXml.Drawing.LineEndWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public DocumentModel.Drawings.LineEndLengthKind? Length
  {
    get => (DocumentModel.Drawings.LineEndLengthKind?)OpenXmlElement?.Length?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Length = (DocumentFormat.OpenXml.Drawing.LineEndLengthValues?)value;
    }
  }
  
}
