namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IShapeProperties))]
public class InvertSolidFillFormat: IInvertSolidFillFormat
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.Charts.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
}
