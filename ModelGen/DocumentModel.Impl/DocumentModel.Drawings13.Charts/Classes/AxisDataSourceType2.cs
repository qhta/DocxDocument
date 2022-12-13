namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public class AxisDataSourceType2Impl: ModelElementImpl, AxisDataSourceType2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AxisDataSourceType2Impl(): base() {}
  
  public AxisDataSourceType2Impl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference
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
