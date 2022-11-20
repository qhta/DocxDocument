namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IconSet Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormattingIcon))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormattingValueObject))]
public interface IIconSet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetTypeValues? IconSetTypes { get ; set; }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowValue { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// reverse, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Reverse { get ; set; }
  
  /// <summary>
  /// custom, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Custom { get ; set; }
  
}
