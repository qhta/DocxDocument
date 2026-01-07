namespace DocumentModel.Drawings.Charts;

/// <summary>
///   String Literal.
/// </summary>
public interface StringLiteral
{
  public UInt32? PointCount { get; set; }
  public StringPoints StringPoints { get; set; }
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}