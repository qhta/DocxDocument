namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public interface IStatistics // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public QuartileMethod? QuartileMethod { get ; set; }
  
}
