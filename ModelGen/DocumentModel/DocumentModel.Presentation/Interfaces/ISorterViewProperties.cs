namespace DocumentModel.Presentation;

/// <summary>
/// Slide Sorter View Properties.
/// </summary>
public interface ISorterViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Formatting
  /// </summary>
  public Boolean? ShowFormatting { get ; set; }
  
  /// <summary>
  /// Base properties for Slide Sorter View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
