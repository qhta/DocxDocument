namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public class SampleDataImpl: DocumentModel.Drawings.SampleDataTypeImpl, SampleData
{
  public override DataModel? DataModel
  {
    get;
    set;
  }
  
}
