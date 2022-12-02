namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IconSet Class.
/// </summary>
public interface IIconSet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetKind? IconSetTypes { get ; set; }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowValue { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Percent { get ; set; }
  
  /// <summary>
  /// reverse, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// custom, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Custom { get ; set; }
  
  public Collection<IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public Collection<IConditionalFormattingIcon>? ConditionalFormattingIcons { get ; set; }
  
}
