namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the StateBasedHeader Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Excel.IRefMap))]
public interface IStateBasedHeader // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// uid, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Uid { get ; set; }
  
  /// <summary>
  /// eft, this property is only available in Office 2016 and later.
  /// </summary>
  public FeatureType? Eft { get ; set; }
  
  /// <summary>
  /// eftx, this property is only available in Office 2016 and later.
  /// </summary>
  public ExtFeatureType? Eftx { get ; set; }
  
  /// <summary>
  /// seft, this property is only available in Office 2016 and later.
  /// </summary>
  public SubFeatureType? Seft { get ; set; }
  
  /// <summary>
  /// seftx, this property is only available in Office 2016 and later.
  /// </summary>
  public ExtSubFeatureType? Seftx { get ; set; }
  
  /// <summary>
  /// RefMap.
  /// </summary>
  public IRefMap? RefMap { get ; set; }
  
}
