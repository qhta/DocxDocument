namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingIcon Class.
/// </summary>
public interface IConditionalFormattingIcon // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.IconSetTypeKind? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? IconId { get ; set; }
  
}
