namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Heading Pairs.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public class HeadingPairs: IHeadingPairs
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
