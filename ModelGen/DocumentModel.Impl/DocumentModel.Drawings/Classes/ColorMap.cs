namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorMap Class.
/// </summary>
public class ColorMapImpl: DocumentModel.Drawings.ColorMappingType2Impl, ColorMap
{
  public override ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
