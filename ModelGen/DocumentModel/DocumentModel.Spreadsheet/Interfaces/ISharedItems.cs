namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SharedItems Class.
/// </summary>
public interface ISharedItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Contains Semi Mixed Data Types
  /// </summary>
  public Boolean? ContainsSemiMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Non Date
  /// </summary>
  public Boolean? ContainsNonDate { get ; set; }
  
  /// <summary>
  /// Contains Date
  /// </summary>
  public Boolean? ContainsDate { get ; set; }
  
  /// <summary>
  /// Contains String
  /// </summary>
  public Boolean? ContainsString { get ; set; }
  
  /// <summary>
  /// Contains Blank
  /// </summary>
  public Boolean? ContainsBlank { get ; set; }
  
  /// <summary>
  /// Contains Mixed Data Types
  /// </summary>
  public Boolean? ContainsMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Numbers
  /// </summary>
  public Boolean? ContainsNumber { get ; set; }
  
  /// <summary>
  /// Contains Integer
  /// </summary>
  public Boolean? ContainsInteger { get ; set; }
  
  /// <summary>
  /// Minimum Numeric Value
  /// </summary>
  public Double? MinValue { get ; set; }
  
  /// <summary>
  /// Maximum Numeric Value
  /// </summary>
  public Double? MaxValue { get ; set; }
  
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
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Long Text
  /// </summary>
  public Boolean? LongText { get ; set; }
  
  public Collection<IMissingItem>? MissingItems { get ; set; }
  
  public Collection<INumberItem>? NumberItems { get ; set; }
  
  public Collection<IBooleanItem>? BooleanItems { get ; set; }
  
  public Collection<IErrorItem>? ErrorItems { get ; set; }
  
  public Collection<IStringItem>? StringItems { get ; set; }
  
  public Collection<IDateTimeItem>? DateTimeItems { get ; set; }
  
}
