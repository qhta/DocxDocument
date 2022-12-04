namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public class ChartText1
{
  /// <summary>
  /// String Reference.
  /// </summary>
  public StringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rich Text.
  /// </summary>
  public RichText? RichText
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
