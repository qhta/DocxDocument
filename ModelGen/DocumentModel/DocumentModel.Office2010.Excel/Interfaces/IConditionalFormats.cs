namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormats Class.
/// </summary>
public interface IConditionalFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IConditionalFormat>? ConditionalFormats { get ; set; }
  
}
