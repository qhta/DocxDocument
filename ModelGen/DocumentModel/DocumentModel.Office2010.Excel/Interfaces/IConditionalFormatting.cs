namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
public interface IConditionalFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Pivot { get ; set; }
  
}
