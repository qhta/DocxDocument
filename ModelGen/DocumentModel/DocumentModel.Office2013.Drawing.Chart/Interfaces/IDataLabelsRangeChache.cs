namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public interface IDataLabelsRangeChache // : DocumentModel.Office2013.Drawing.Chart.IStringDataType
{
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
