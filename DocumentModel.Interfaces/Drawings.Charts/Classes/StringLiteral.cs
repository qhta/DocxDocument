namespace DocumentModel.Drawings.Charts;

/// <summary>
///   String Literal.
/// </summary>
public interface StringLiteral: IModelElement
{
  public UInt32? PointCount { get; set; }
  public Collection<StringPoint>? StringPoints { get; set; }
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}