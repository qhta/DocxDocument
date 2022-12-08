namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public class AxisDataSourceType1Impl: ModelElementImpl, AxisDataSourceType1
{
  public DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public virtual MultiLevelStringReference? MultiLevelStringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public virtual NumberReference? NumberReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public virtual NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public virtual StringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public virtual StringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
