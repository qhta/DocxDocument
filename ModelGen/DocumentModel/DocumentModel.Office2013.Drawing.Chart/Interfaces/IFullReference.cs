namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public interface IFullReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences { get ; set; }
  
}
