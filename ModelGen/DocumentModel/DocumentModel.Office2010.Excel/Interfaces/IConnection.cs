namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Connection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICalculatedMembers))]
public interface IConnection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// culture, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Culture { get ; set; }
  
  /// <summary>
  /// embeddedDataId, this property is only available in Office 2010 and later.
  /// </summary>
  public string? EmbeddedDataId { get ; set; }
  
  /// <summary>
  /// CalculatedMembers.
  /// </summary>
  public DocumentModel.Office2010.Excel.ICalculatedMembers? CalculatedMembers { get ; set; }
  
}
