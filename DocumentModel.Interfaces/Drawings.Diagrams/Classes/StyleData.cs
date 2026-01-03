namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the StyleData Class.
/// </summary>
public interface StyleData: IModelElement
{
  public DataModel? DataModel { get; set; }
}