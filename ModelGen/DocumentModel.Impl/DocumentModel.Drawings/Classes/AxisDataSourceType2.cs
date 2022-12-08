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
  
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public MultiLevelStringReference? MultiLevelStringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public NumberReference? NumberReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference
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
