namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Part Titles.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public class TitlesOfParts: ITitlesOfParts
{
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector
  {
    get;
    set;
  }
  
}
