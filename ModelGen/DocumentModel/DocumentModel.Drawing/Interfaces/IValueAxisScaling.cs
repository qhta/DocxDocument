namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueAxisScaling Class.
/// </summary>
public interface IValueAxisScaling // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Max { get ; set; }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Min { get ; set; }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? MajorUnit { get ; set; }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? MinorUnit { get ; set; }
  
}
