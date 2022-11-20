namespace DocumentModel.VariantTypes;

/// <summary>
/// Vector.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTClipboardData))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVariant))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTClassId))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTCurrency))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTError))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBool))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDate))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTFileTime))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDouble))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTFloat))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInt64))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTShort))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTLPSTR))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTLPWSTR))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBString))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInt64))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedShort))]
public class VTVector: IVTVector
{
  /// <summary>
  /// Vector Base Type
  /// </summary>
  public VectorBaseValues? BaseType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vector Size
  /// </summary>
  public uint? Size
  {
    get;
    set;
  }
  
}
