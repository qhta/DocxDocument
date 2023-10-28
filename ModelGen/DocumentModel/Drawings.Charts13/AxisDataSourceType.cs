namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the AxisDataSourceType Class.
/// </summary>
public partial class AxisDataSourceType
{
  
  /// <summary>
  ///   Multi Level String Reference.
  /// </summary>
  public DMDC.MultiLevelStringReference? MultiLevelStringReference { get; set; }
  
  
  /// <summary>
  ///   Number Reference.
  /// </summary>
  public DMDC.NumberReference? NumberReference { get; set; }
  
  
  /// <summary>
  ///   Number Literal.
  /// </summary>
  public DMDC.NumberLiteral? NumberLiteral { get; set; }
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  public DMDC.StringReference? StringReference { get; set; }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  public DMDC.StringLiteral? StringLiteral { get; set; }
  
}
