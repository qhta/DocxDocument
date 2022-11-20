namespace DocumentModel.VariantTypes;

/// <summary>
/// Array.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVariant))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTCurrency))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTError))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBool))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDate))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDecimal))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDouble))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTFloat))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInteger))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTShort))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBString))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInteger))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedShort))]
public interface IVTArray // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Array Lower Bounds Attribute
  /// </summary>
  public int? LowerBounds { get ; set; }
  
  /// <summary>
  /// Array Upper Bounds Attribute
  /// </summary>
  public int? UpperBounds { get ; set; }
  
  /// <summary>
  /// Array Base Type
  /// </summary>
  public ArrayBaseValues? BaseType { get ; set; }
  
}
