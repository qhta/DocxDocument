namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public partial class ChartText3
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference { get; set; }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.RichText? RichText { get; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringLiteral? StringLiteral { get; set; }
  
}
