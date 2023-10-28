namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartText Class.
/// </summary>
public partial class ChartText
{
  
  /// <summary>
  ///   String Reference.
  /// </summary>
  public DMDC.StringReference? StringReference { get; set; }
  
  
  /// <summary>
  ///   Rich Text.
  /// </summary>
  public DMDC.RichText? RichText { get; set; }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  public DMDC.StringLiteral? StringLiteral { get; set; }
  
}
