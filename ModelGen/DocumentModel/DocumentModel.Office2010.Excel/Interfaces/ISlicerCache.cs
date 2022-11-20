namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerCache Class.
/// </summary>
public interface ISlicerCache // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
