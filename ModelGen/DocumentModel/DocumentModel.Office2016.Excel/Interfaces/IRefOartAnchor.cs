namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RefOartAnchor Class.
/// </summary>
public interface IRefOartAnchor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// n, this property is only available in Office 2016 and later.
  /// </summary>
  public string? N { get ; set; }
  
  /// <summary>
  /// ajt, this property is only available in Office 2016 and later.
  /// </summary>
  public AdjustType? Ajt { get ; set; }
  
  /// <summary>
  /// ajtx, this property is only available in Office 2016 and later.
  /// </summary>
  public AdjustTypeExt? Ajtx { get ; set; }
  
  /// <summary>
  /// homeRef, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? HomeRef { get ; set; }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public string? R { get ; set; }
  
  /// <summary>
  /// fromRowOff, this property is only available in Office 2016 and later.
  /// </summary>
  public long? FromRowOff { get ; set; }
  
  /// <summary>
  /// fromColOff, this property is only available in Office 2016 and later.
  /// </summary>
  public long? FromColOff { get ; set; }
  
  /// <summary>
  /// toRowOff, this property is only available in Office 2016 and later.
  /// </summary>
  public long? ToRowOff { get ; set; }
  
  /// <summary>
  /// toColOff, this property is only available in Office 2016 and later.
  /// </summary>
  public long? ToColOff { get ; set; }
  
  /// <summary>
  /// cx, this property is only available in Office 2016 and later.
  /// </summary>
  public long? Cx { get ; set; }
  
  /// <summary>
  /// cy, this property is only available in Office 2016 and later.
  /// </summary>
  public long? Cy { get ; set; }
  
  /// <summary>
  /// x, this property is only available in Office 2016 and later.
  /// </summary>
  public long? X { get ; set; }
  
  /// <summary>
  /// y, this property is only available in Office 2016 and later.
  /// </summary>
  public long? Y { get ; set; }
  
  /// <summary>
  /// oat, this property is only available in Office 2016 and later.
  /// </summary>
  public OartAnchorType? Oat { get ; set; }
  
}
