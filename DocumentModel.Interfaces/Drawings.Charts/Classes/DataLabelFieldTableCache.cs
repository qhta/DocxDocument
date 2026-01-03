namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public interface DataLabelFieldTableCache: IModelElement
{
  public UInt32? PointCount { get; set; }
  public Collection<StringPoint>? StringPoints { get; set; }
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}