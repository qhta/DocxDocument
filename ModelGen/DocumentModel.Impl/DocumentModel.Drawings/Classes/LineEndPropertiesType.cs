namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public class LineEndPropertiesTypeImpl: ModelElementImpl, LineEndPropertiesType
{
  public DocumentFormat.OpenXml.Drawing.LineEndPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineEndPropertiesType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineEndPropertiesTypeImpl(): base() {}
  
  public LineEndPropertiesTypeImpl(DocumentFormat.OpenXml.Drawing.LineEndPropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public LineEndKind? Type
  {
    get => (LineEndKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.LineEndValues?)value;
    }
  }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public LineEndWidthKind? Width
  {
    get => (LineEndWidthKind?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (DocumentFormat.OpenXml.Drawing.LineEndWidthValues?)value;
    }
  }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public LineEndLengthKind? Length
  {
    get => (LineEndLengthKind?)OpenXmlElement?.Length?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Length = (DocumentFormat.OpenXml.Drawing.LineEndLengthValues?)value;
    }
  }
  
}
