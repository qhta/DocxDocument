namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public partial class NumberingFormat3Impl: ModelElementImpl, NumberingFormat3
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingFormat3Impl(): base() {}
  
  public NumberingFormat3Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat openXmlElement): base(openXmlElement)
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
