namespace DocumentModel.Math;

/// <summary>
/// Literal.
/// </summary>
public interface ILiteral // : DocumentFormat.OpenXml.Math.OnOffType
{
  /// <summary>
  /// value
  /// </summary>
  public BooleanValues? Val { get ; set; }
  
}
