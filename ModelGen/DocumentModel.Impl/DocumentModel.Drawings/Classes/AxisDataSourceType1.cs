namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public class AxisDataSourceType1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.AxisDataSourceType>, AxisDataSourceType1
{
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
