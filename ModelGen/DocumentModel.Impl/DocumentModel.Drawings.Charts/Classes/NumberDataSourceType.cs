namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public class NumberDataSourceTypeImpl: ModelElementImpl, NumberDataSourceType
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberDataSourceTypeImpl(): base() {}
  
  public NumberDataSourceTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
}
