namespace DocumentModel.Drawings;

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
  public virtual MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public virtual NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public virtual NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public virtual StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public virtual StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
