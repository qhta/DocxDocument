namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public class AxisDataSourceTypeImpl: ModelElementImpl, AxisDataSourceType
{
  public DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AxisDataSourceTypeImpl(): base() {}
  
  public AxisDataSourceTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
