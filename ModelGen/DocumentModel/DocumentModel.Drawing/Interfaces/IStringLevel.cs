namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public interface IStringLevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  public Collection<IChartStringValue>? ChartStringValues { get ; set; }
  
}
