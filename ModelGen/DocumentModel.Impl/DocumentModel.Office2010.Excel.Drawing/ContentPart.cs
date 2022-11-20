namespace DocumentModel.Office2010.Excel.Drawing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.IApplicationNonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.Drawing.IExcelNonVisualContentPartShapeProperties))]
public class ContentPart: IContentPart
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelationshipId
  {
    get;
    set;
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExcelNonVisualContentPartShapeProperties.
  /// </summary>
  public IExcelNonVisualContentPartShapeProperties? ExcelNonVisualContentPartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.ITransform2D? Transform2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
