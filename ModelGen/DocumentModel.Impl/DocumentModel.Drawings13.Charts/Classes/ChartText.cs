namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public class ChartTextImpl: ModelElementImpl, ChartText
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartTextImpl(): base() {}
  
  public ChartTextImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// String Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.RichText? RichText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
