namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Number Literal.
/// </summary>
public class NumberLiteral: ModelElement
{
  public String? FormatCode { get; set; }

  public UInt32? PointCount { get; set; }

  public Collection<NumericPoint>? NumericPoints { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}