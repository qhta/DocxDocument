namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SharedItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBooleanItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDateTimeItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IErrorItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStringItem))]
public interface ISharedItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Contains Semi Mixed Data Types
  /// </summary>
  public bool? ContainsSemiMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Non Date
  /// </summary>
  public bool? ContainsNonDate { get ; set; }
  
  /// <summary>
  /// Contains Date
  /// </summary>
  public bool? ContainsDate { get ; set; }
  
  /// <summary>
  /// Contains String
  /// </summary>
  public bool? ContainsString { get ; set; }
  
  /// <summary>
  /// Contains Blank
  /// </summary>
  public bool? ContainsBlank { get ; set; }
  
  /// <summary>
  /// Contains Mixed Data Types
  /// </summary>
  public bool? ContainsMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Numbers
  /// </summary>
  public bool? ContainsNumber { get ; set; }
  
  /// <summary>
  /// Contains Integer
  /// </summary>
  public bool? ContainsInteger { get ; set; }
  
  /// <summary>
  /// Minimum Numeric Value
  /// </summary>
  public double? MinValue { get ; set; }
  
  /// <summary>
  /// Maximum Numeric Value
  /// </summary>
  public double? MaxValue { get ; set; }
  
  /// <summary>
  /// Minimum Date Time
  /// </summary>
  public DateTime? MinDate { get ; set; }
  
  /// <summary>
  /// Maximum Date Time Value
  /// </summary>
  public DateTime? MaxDate { get ; set; }
  
  /// <summary>
  /// Shared Items Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// Long Text
  /// </summary>
  public bool? LongText { get ; set; }
  
}
