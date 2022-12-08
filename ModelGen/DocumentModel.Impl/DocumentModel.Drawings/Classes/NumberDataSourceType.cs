namespace DocumentModel.Drawings;

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
  
}
