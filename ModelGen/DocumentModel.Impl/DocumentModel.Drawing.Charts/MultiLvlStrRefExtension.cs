namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFormulaReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFullReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILevelReference))]
public class MultiLvlStrRefExtension: IMultiLvlStrRefExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
