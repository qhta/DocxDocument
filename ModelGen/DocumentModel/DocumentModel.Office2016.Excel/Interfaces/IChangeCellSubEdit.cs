namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the ChangeCellSubEdit Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRevCell))]
public interface IChangeCellSubEdit // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public string? R { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public FillType? T { get ; set; }
  
  /// <summary>
  /// x, this property is only available in Office 2016 and later.
  /// </summary>
  public FillTypeExt? X { get ; set; }
  
  /// <summary>
  /// w, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? W { get ; set; }
  
}
