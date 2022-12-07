namespace DocumentModel.Drawings;

/// <summary>
/// Override Color Mapping.
/// </summary>
public class OverrideColorMappingImpl: DocumentModel.Drawings.ColorMappingType2Impl, OverrideColorMapping
{
  public override ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
