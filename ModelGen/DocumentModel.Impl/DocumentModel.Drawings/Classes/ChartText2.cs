namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public class ChartText2Impl: ModelElementImpl, ChartText2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// String Reference.
  /// </summary>
  public StringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public RichText? RichText
  {
    get;
    set;
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public StringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
