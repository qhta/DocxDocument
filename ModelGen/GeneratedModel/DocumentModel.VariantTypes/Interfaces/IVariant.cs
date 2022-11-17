namespace DocumentModel.VariantTypes;

public interface IVariant // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IVariant? InnerVariant { get ; set; }
  
  public IVTVector? VTVector { get ; set; }
  
  public IVTArray? VTArray { get ; set; }
  
  public IVTBlob? VTBlob { get ; set; }
  
  public IVTOBlob? VTOBlob { get ; set; }
  
  public IVTEmpty? VTEmpty { get ; set; }
  
  public IVTNull? VTNull { get ; set; }
  
  public IVTByte? VTByte { get ; set; }
  
  public IVTShort? VTShort { get ; set; }
  
  public IVTInt32? VTInt32 { get ; set; }
  
  public IVTInt64? VTInt64 { get ; set; }
  
  public IVTInteger? VTInteger { get ; set; }
  
  public IVTUnsignedByte? VTUnsignedByte { get ; set; }
  
  public IVTUnsignedShort? VTUnsignedShort { get ; set; }
  
  public IVTUnsignedInt32? VTUnsignedInt32 { get ; set; }
  
  public IVTUnsignedInt64? VTUnsignedInt64 { get ; set; }
  
  public IVTUnsignedInteger? VTUnsignedInteger { get ; set; }
  
  public IVTFloat? VTFloat { get ; set; }
  
  public IVTDouble? VTDouble { get ; set; }
  
  public IVTDecimal? VTDecimal { get ; set; }
  
  public IVTLPSTR? VTLPSTR { get ; set; }
  
  public IVTLPWSTR? VTLPWSTR { get ; set; }
  
  public IVTBString? VTBString { get ; set; }
  
  public IVTDate? VTDate { get ; set; }
  
  public IVTFileTime? VTFileTime { get ; set; }
  
  public IVTBool? VTBool { get ; set; }
  
  public IVTCurrency? VTCurrency { get ; set; }
  
  public IVTError? VTError { get ; set; }
  
  public IVTStreamData? VTStreamData { get ; set; }
  
  public IVTOStreamData? VTOStreamData { get ; set; }
  
  public IVTStorage? VTStorage { get ; set; }
  
  public IVTOStorage? VTOStorage { get ; set; }
  
  public IVTVStreamData? VTVStreamData { get ; set; }
  
  public IVTClassId? VTClassId { get ; set; }
  
  public IVTClipboardData? VTClipboardData { get ; set; }
  
}
