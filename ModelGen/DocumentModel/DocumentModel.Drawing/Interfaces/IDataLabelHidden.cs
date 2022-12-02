namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public interface IDataLabelHidden // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Idx { get ; set; }
  
}
