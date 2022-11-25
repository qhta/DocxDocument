namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ParentLabelLayout Class.
/// </summary>
public interface IParentLabelLayout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal? ParentLabelLayoutVal { get ; set; }
  
}
