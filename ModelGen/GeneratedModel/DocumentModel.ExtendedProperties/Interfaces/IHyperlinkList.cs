namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Hyperlink List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
public interface IHyperlinkList // : DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType
{
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector { get ; set; }
  
}
