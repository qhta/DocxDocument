namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public interface IAxisUnits // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public AxisUnit? Unit { get ; set; }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public IAxisUnitsLabel? AxisUnitsLabel { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
