namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Text Style.
/// </summary>
public interface ITableCellTextStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bold
  /// </summary>
  public BooleanStyleValues? Bold { get ; set; }
  
  /// <summary>
  /// Italic
  /// </summary>
  public BooleanStyleValues? Italic { get ; set; }
  
}
