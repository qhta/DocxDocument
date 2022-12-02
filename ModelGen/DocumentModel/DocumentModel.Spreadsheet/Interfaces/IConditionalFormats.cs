namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormats Class.
/// </summary>
public interface IConditionalFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IConditionalFormat>? ConditionalFormats { get ; set; }
  
}
