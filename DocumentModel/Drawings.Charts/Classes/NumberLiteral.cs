namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Number Literal.
/// </summary>
public class NumberLiteral: ModelElement
{
  public string? FormatCode { get; set; }

  public UInt32? PointCount { get; set; }

  public Collection<NumericPoint>? NumericPoints { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}