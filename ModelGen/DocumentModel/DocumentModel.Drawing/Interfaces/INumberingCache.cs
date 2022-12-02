namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public interface INumberingCache // : DocumentModel.Drawing.INumberDataType
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<INumericPoint>? NumericPoints { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
