namespace DocumentModel.Drawings;

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
  public MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference
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
