namespace DocumentModel.Spreadsheet;

/// <summary>
/// Icon Set.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormatValueObject))]
public interface IIconSet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Icon Set
  /// </summary>
  public IconSet? IconSetValue { get ; set; }
  
  /// <summary>
  /// Show Value
  /// </summary>
  public bool? ShowValue { get ; set; }
  
  /// <summary>
  /// Percent
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// Reverse Icons
  /// </summary>
  public bool? Reverse { get ; set; }
  
}
