namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public class NumberingFormat2Impl: ModelElementImpl, NumberingFormat2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked
  {
    get;
    set;
  }
  
}
