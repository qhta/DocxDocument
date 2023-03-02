namespace DocumentModel.Drawings.Charts;

/// <summary>
///   String Literal.
/// </summary>
public record StringLiteral
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}