namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Part Titles.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public interface ITitlesOfParts // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector { get ; set; }
  
}
