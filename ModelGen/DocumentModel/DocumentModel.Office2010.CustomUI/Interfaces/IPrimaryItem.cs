namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstagePrimaryMenu))]
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IBackstageRegularButton))]
public interface IPrimaryItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  public IBackstageRegularButton? BackstageRegularButton { get ; set; }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  public IBackstagePrimaryMenu? BackstagePrimaryMenu { get ; set; }
  
}
