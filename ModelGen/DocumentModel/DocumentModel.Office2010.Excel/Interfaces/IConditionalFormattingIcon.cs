namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingIcon Class.
/// </summary>
public interface IConditionalFormattingIcon // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetTypeValues? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? IconId { get ; set; }
  
}
