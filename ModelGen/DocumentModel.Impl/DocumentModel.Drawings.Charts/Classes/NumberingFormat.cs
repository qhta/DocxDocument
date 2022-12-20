namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Number Format.
/// </summary>
public partial class NumberingFormatImpl: ModelElementImpl, NumberingFormat
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumberingFormatImpl(): base() {}
  
  public NumberingFormatImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode
  {
    get => (System.String?)OpenXmlElement?.FormatCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked
  {
    get => (System.Boolean?)OpenXmlElement?.SourceLinked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SourceLinked = (System.Boolean?)value;
    }
  }
  
}
