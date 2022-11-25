namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SharedItems Class.
/// </summary>
public interface ISharedItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Contains Semi Mixed Data Types
  /// </summary>
  public System.Boolean? ContainsSemiMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Non Date
  /// </summary>
  public System.Boolean? ContainsNonDate { get ; set; }
  
  /// <summary>
  /// Contains Date
  /// </summary>
  public System.Boolean? ContainsDate { get ; set; }
  
  /// <summary>
  /// Contains String
  /// </summary>
  public System.Boolean? ContainsString { get ; set; }
  
  /// <summary>
  /// Contains Blank
  /// </summary>
  public System.Boolean? ContainsBlank { get ; set; }
  
  /// <summary>
  /// Contains Mixed Data Types
  /// </summary>
  public System.Boolean? ContainsMixedTypes { get ; set; }
  
  /// <summary>
  /// Contains Numbers
  /// </summary>
  public System.Boolean? ContainsNumber { get ; set; }
  
  /// <summary>
  /// Contains Integer
  /// </summary>
  public System.Boolean? ContainsInteger { get ; set; }
  
  /// <summary>
  /// Minimum Numeric Value
  /// </summary>
  public System.Double? MinValue { get ; set; }
  
  /// <summary>
  /// Maximum Numeric Value
  /// </summary>
  public System.Double? MaxValue { get ; set; }
  
  /// <summary>
  /// Minimum Date Time
  /// </summary>
  public System.DateTime? MinDate { get ; set; }
  
  /// <summary>
  /// Maximum Date Time Value
  /// </summary>
  public System.DateTime? MaxDate { get ; set; }
  
  /// <summary>
  /// Shared Items Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// Long Text
  /// </summary>
  public System.Boolean? LongText { get ; set; }
  
}
