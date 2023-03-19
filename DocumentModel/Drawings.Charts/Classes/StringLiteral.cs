namespace DocumentModel.Drawings.Charts;

/// <summary>
///   String Literal.
/// </summary>
public class StringLiteral: ModelElement
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}