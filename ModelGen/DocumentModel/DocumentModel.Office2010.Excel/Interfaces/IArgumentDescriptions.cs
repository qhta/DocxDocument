namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ArgumentDescriptions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IArgumentDescription))]
public interface IArgumentDescriptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count { get ; set; }
  
}
