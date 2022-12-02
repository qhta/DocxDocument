namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface IData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public Collection<INumericDimension>? NumericDimensions { get ; set; }
  
  public Collection<IStringDimension>? StringDimensions { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
