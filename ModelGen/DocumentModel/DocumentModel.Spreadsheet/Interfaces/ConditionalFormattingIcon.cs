namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingIcon Class.
/// </summary>
public interface ConditionalFormattingIcon // : System.Boolean
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetKind? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? IconId { get ; set; }
  
}
