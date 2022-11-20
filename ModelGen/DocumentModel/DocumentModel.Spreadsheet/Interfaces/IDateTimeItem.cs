namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Time.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertyIndex))]
public interface IDateTimeItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public DateTime? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public bool? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item Value
  /// </summary>
  public bool? Calculated { get ; set; }
  
  /// <summary>
  /// Caption
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public uint? PropertyCount { get ; set; }
  
}
