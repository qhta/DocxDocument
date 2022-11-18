namespace DocumentModel.Spreadsheet;

/// <summary>
/// Boolean.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertyIndex))]
public interface IBooleanItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public bool? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public bool? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
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
