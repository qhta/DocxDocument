namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStrDataExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public interface IStringCache // : DocumentFormat.OpenXml.Drawing.Charts.StringDataType
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public IPointCount? PointCount { get ; set; }
  
}
