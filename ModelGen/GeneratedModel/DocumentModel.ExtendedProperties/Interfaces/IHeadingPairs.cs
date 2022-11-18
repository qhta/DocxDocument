namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Heading Pairs.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public interface IHeadingPairs // : DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType
{
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector { get ; set; }
  
}
