namespace DocumentModel.Drawings;

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
  public StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public RichText? RichText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
