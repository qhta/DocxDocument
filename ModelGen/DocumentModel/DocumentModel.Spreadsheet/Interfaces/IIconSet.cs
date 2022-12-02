namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IconSet Class.
/// </summary>
public interface IIconSet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.IconSetKind? IconSetTypes { get ; set; }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowValue { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Percent { get ; set; }
  
  /// <summary>
  /// reverse, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// custom, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Custom { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingIcon>? ConditionalFormattingIcons { get ; set; }
  
}
