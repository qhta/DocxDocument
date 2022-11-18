namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Legend Entry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDelete))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
public interface ILegendEntry // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
}
