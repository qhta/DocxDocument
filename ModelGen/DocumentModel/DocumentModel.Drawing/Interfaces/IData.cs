namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface IData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  public DocumentModel.Drawing.INumericDimension? NumericDimension { get ; set; }
  
  public DocumentModel.Drawing.IStringDimension? StringDimension { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
