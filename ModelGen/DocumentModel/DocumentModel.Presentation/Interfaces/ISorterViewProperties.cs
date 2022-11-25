namespace DocumentModel.Presentation;

/// <summary>
/// Slide Sorter View Properties.
/// </summary>
public interface ISorterViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Formatting
  /// </summary>
  public System.Boolean? ShowFormatting { get ; set; }
  
  /// <summary>
  /// Base properties for Slide Sorter View.
  /// </summary>
  public DocumentModel.Presentation.ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
