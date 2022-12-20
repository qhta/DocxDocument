namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public partial class NumberFormatImpl: ModelElementImpl, NumberFormat
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberFormatImpl(): base() {}
  
  public NumberFormatImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
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
  /// sourceLinked, this property is only available in Office 2016 and later.
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
