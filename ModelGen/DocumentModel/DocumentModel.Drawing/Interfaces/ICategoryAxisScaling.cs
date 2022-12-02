namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public interface ICategoryAxisScaling // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public String? GapWidth { get ; set; }
  
}
